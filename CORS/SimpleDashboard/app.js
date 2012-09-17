$(document).ready(function(){
	$.ajaxSetup({ accepts: "application/json" });						   
});

etUrl = "http://ettrial.catchsoftware.net";
apiUrl = etUrl + "/api";
searchUrl = apiUrl + "/search";
login = "viewonly";
pass = "view2012";

function readableEntityName(type) {
	switch (type)
	{
		case "testscript":
			return "Scripts";
		case "testscriptassignment":
			return "Assignments";
		case "requirement":
			return "User Stories";
		case "agilerun":
			return "Adhoc Runs";
		case "automatedtest":
			return "Automated Tests";
		case "automatedtestassignment":
			return "Automated Runs";
		case "incident":
			return "Issues";
		default:
			return type;
	}
}

function tqlAggregateSearch(tql, success){
	$.ajax({
		url: searchUrl,
		type: "GET",		
		data: "tql=" + escape(tql), 
	    xhrFields: {
	       withCredentials: true
	    },
	    crossDomain: true,
	    beforeSend: function(xhr) {
			xhr.setRequestHeader("Authorization", "Basic " + encodeBase64(login + ":" + password));
		},
		success: success
	});
}

function tqlSearch(tql, top, format, success){
	$.ajax({
		url: searchUrl,
		type: "GET",
		data: "tql=" + escape(tql)  + "&$top=" + top + "&format=" + format, 
	    xhrFields: {
	       withCredentials: true
	    },
	    crossDomain: true,
	    beforeSend: function(xhr) {
			xhr.setRequestHeader("Authorization", "Basic " + encodeBase64(login + ":" + password));
		},
		success: success
	});
}

function formatDate(date){	
    var d = date.getDate();
    var m = date.getMonth()+1;
    var y = date.getFullYear();
    return '' + y +'-'+ (m<=9?'0'+m:m) +'-'+ (d<=9?'0'+d:d);
}

function drawSearchResults(tql, projectName, elementId) {
	var max = 5;
	tqlSearch(tql, max, "grid", function(data) {
		var content = '';

		if (data.Items.length > 0) {
			content += '<ul class="items">';
			for (i=0; i<data.Items.length; i++) {
				var result=data.Items[i];
				var editUrl =etUrl + result.EditLink;
				var date = formatDate(new Date(result.LastUpdatedAt));
				content += '<li><span class="when">'+ date +'</span> <span class="entity-' + result.EntityType + '"></span> <a target="_blank" class="' + result.EntityType + '" href="' + editUrl + '">' + result.Name + '</a></li>';
			}

			content += '</ul>';
		} else {
			content += '<span class="no-data">...No data...</span>';
		}

		$(elementId).append(content);
	});
}

function drawRecentlyUpdated(elementId, projectName) {
	var tql = "Project = \"" + projectName + "\" ORDER BY LastUpdatedAt DESC";
	var elId = '#' + elementId + ' .recently-updated';
	drawSearchResults(tql, projectName, elId);
}

function drawRecentlyFailed(elementId, projectName) {
	var tql = "Status = Failed AND Project = \"" + projectName + "\" ORDER BY LastUpdatedAt DESC";
	var elId = '#' + elementId + ' .recently-failed';
	drawSearchResults(tql, projectName, elId);
}

function drawChart(projectName, group) {
	var data = [];

	for (entityType in group) {
		var count = group[entityType].COUNT;
		data.push([readableEntityName(entityType), count]);				
	}

	if (data.length == 0) return;

	var dataTable = google.visualization.arrayToDataTable(data);

	var options = {
  		title:  projectName + ' Stats'
	};

	var elementId = projectName.replace(' ','_').replace("'","");

	var content = '<div id="' + elementId + '""><div class="totals-chart" style="width: 600px; height: 500px;"></div>' +
    	'<div class="recently"><div class="recently-updated"><span class="title">Recently Updated</span></div>' + 
    	'<div class="recently-failed"><span class="title">Recently Failed</span></div></div></div>';

	$('.results').append(content);

	$('#' + elementId + ' .totals-chart').each(function() {
		var chart = new google.visualization.PieChart(this);
		chart.draw(dataTable, options);
		drawRecentlyUpdated(elementId, projectName);
		drawRecentlyFailed(elementId, projectName);
	});    	
}

function drawCharts() {
	tqlAggregateSearch('GROUP BY Project { GROUP BY EntityType { COUNT } }', function(data) {
		for (projectName in data.Results.GroupByProject) {
			var group = data.Results.GroupByProject[projectName].GroupByEntityType;
			drawChart(projectName, group);
		}
	});
}

google.load("visualization", "1", {packages:["corechart"]});

google.setOnLoadCallback(drawCharts);
