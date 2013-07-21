using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EnterpriseTester.API.Client.Models;

namespace EnterpriseTester.API.Client
{
    public partial class Client
    {


        /// <summary>
        /// Sends a GET to '/api/'
        /// </summary>
        /// <returns></returns>
        public virtual Resources ListRootResources()
        {
            var operation = Operations.ListRootResources();
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Resources>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/'  (asynchronous)
        /// </summary>
        /// <returns></returns>
        public virtual async Task<Resources> ListRootResourcesAsync()
        {
            var operation = Operations.ListRootResources();
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Resources>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/agilerun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AgileRun GetAgileRun(string id, string expand = null)
        {
            var operation = Operations.GetAgileRun(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AgileRun>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/agilerun/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AgileRun> GetAgileRunAsync(string id, string expand = null)
        {
            var operation = Operations.GetAgileRun(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AgileRun>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/agilerun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AgileRun UpdateAgileRun(string id, CreateOrUpdateAgileRun model, string expand = null)
        {
            var operation = Operations.UpdateAgileRun(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AgileRun>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/agilerun/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AgileRun> UpdateAgileRunAsync(string id, CreateOrUpdateAgileRun model, string expand = null)
        {
            var operation = Operations.UpdateAgileRun(id, model, expand);
		    var request = operation.BuildRequest(_client);
            request.Headers.Add("wait-until-indexed","false");
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AgileRun>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/agilerun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteAgileRun(string id)
        {
            var operation = Operations.DeleteAgileRun(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/agilerun/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteAgileRunAsync(string id)
        {
            var operation = Operations.DeleteAgileRun(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/agilerun/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetAgileRunAllRelationships(string id)
        {
            var operation = Operations.GetAgileRunAllRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/agilerun/{id}/allrelationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetAgileRunAllRelationshipsAsync(string id)
        {
            var operation = Operations.GetAgileRunAllRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/agilerun/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetAgileRunRelationships(string id)
        {
            var operation = Operations.GetAgileRunRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/agilerun/{id}/relationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetAgileRunRelationshipsAsync(string id)
        {
            var operation = Operations.GetAgileRunRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/agileruns'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<AgileRun> SearchAgileRuns(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAgileRuns(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AgileRun>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/agileruns'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AgileRun>> SearchAgileRunsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAgileRuns(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AgileRun>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/agileruns'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AgileRun CreateAgileRun(CreateOrUpdateAgileRun model, string expand = null)
        {
            var operation = Operations.CreateAgileRun(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AgileRun>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/agileruns'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AgileRun> CreateAgileRunAsync(CreateOrUpdateAgileRun model, string expand = null)
        {
            var operation = Operations.CreateAgileRun(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AgileRun>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/assignedtosearch'
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual QueryResults<AssignedTo> SearchForUsersGroupsAndSpecialUsers(string query = null, bool? valuesqry = null)
        {
            var operation = Operations.SearchForUsersGroupsAndSpecialUsers(query, valuesqry);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AssignedTo>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/assignedtosearch'  (asynchronous)
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AssignedTo>> SearchForUsersGroupsAndSpecialUsersAsync(string query = null, bool? valuesqry = null)
        {
            var operation = Operations.SearchForUsersGroupsAndSpecialUsers(query, valuesqry);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AssignedTo>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/assignedtosearch'
        /// </summary>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <returns></returns>
        public virtual HttpResponseMessage SearchForUsersGroupsAndSpecialUsersUsingPostMethod(string query = null, string valuesqry = null)
        {
            var operation = Operations.SearchForUsersGroupsAndSpecialUsersUsingPostMethod(query, valuesqry);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/assignedtosearch'  (asynchronous)
        /// </summary>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SearchForUsersGroupsAndSpecialUsersUsingPostMethodAsync(string query = null, string valuesqry = null)
        {
            var operation = Operations.SearchForUsersGroupsAndSpecialUsersUsingPostMethod(query, valuesqry);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/attachment/{id}/contents'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage RetrieveAttachmentContents(string id)
        {
            var operation = Operations.RetrieveAttachmentContents(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a GET to '/api/attachment/{id}/contents'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> RetrieveAttachmentContentsAsync(string id)
        {
            var operation = Operations.RetrieveAttachmentContents(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtest/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AutomatedTest GetAutomatedTest(string id, string expand = null)
        {
            var operation = Operations.GetAutomatedTest(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTest>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtest/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTest> GetAutomatedTestAsync(string id, string expand = null)
        {
            var operation = Operations.GetAutomatedTest(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTest>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/automatedtest/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AutomatedTest UpdateAutomatedTest(string id, CreateOrUpdateAutomatedTest model, string expand = null)
        {
            var operation = Operations.UpdateAutomatedTest(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTest>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/automatedtest/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTest> UpdateAutomatedTestAsync(string id, CreateOrUpdateAutomatedTest model, string expand = null)
        {
            var operation = Operations.UpdateAutomatedTest(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTest>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/automatedtest/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteAutomatedTest(string id)
        {
            var operation = Operations.DeleteAutomatedTest(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtest/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteAutomatedTestAsync(string id)
        {
            var operation = Operations.DeleteAutomatedTest(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtest/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetAutomatedTestAllRelationships(string id)
        {
            var operation = Operations.GetAutomatedTestAllRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtest/{id}/allrelationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetAutomatedTestAllRelationshipsAsync(string id)
        {
            var operation = Operations.GetAutomatedTestAllRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtest/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetAutomatedTestRelationships(string id)
        {
            var operation = Operations.GetAutomatedTestRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtest/{id}/relationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetAutomatedTestRelationshipsAsync(string id)
        {
            var operation = Operations.GetAutomatedTestRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtest/{testId}/assignments'
        /// </summary>
        /// <param name="testId">a path parameter (no description)</param>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<AutomatedTestAssignment> SearchAutomatedTestAssignmentsForAutomatedTest(string testId, string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAutomatedTestAssignmentsForAutomatedTest(testId, tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AutomatedTestAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtest/{testId}/assignments'  (asynchronous)
        /// </summary>
        /// <param name="testId">a path parameter (no description)</param>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AutomatedTestAssignment>> SearchAutomatedTestAssignmentsForAutomatedTestAsync(string testId, string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAutomatedTestAssignmentsForAutomatedTest(testId, tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AutomatedTestAssignment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtest/{testId}/assignments'
        /// </summary>
        /// <param name="testId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AutomatedTestAssignment CreateAssignmentForAutomatedTest(string testId, CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            var operation = Operations.CreateAssignmentForAutomatedTest(testId, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestAssignment>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtest/{testId}/assignments'  (asynchronous)
        /// </summary>
        /// <param name="testId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestAssignment> CreateAssignmentForAutomatedTestAsync(string testId, CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            var operation = Operations.CreateAssignmentForAutomatedTest(testId, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestAssignment>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AutomatedTestAssignment GetAutomatedTestAssignment(string id, string expand = null)
        {
            var operation = Operations.GetAutomatedTestAssignment(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestAssignment>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestAssignment> GetAutomatedTestAssignmentAsync(string id, string expand = null)
        {
            var operation = Operations.GetAutomatedTestAssignment(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestAssignment>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/automatedtestassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AutomatedTestAssignment UpdateAutomatedTestAssignment(string id, CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            var operation = Operations.UpdateAutomatedTestAssignment(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestAssignment>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/automatedtestassignment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestAssignment> UpdateAutomatedTestAssignmentAsync(string id, CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            var operation = Operations.UpdateAutomatedTestAssignment(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestAssignment>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteAutomatedTestAssignment(string id)
        {
            var operation = Operations.DeleteAutomatedTestAssignment(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtestassignment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteAutomatedTestAssignmentAsync(string id)
        {
            var operation = Operations.DeleteAutomatedTestAssignment(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetAutomatedTestAssignmentAllRelationships(string id)
        {
            var operation = Operations.GetAutomatedTestAssignmentAllRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}/allrelationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetAutomatedTestAssignmentAllRelationshipsAsync(string id)
        {
            var operation = Operations.GetAutomatedTestAssignmentAllRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetAutomatedTestAssignmentRelationships(string id)
        {
            var operation = Operations.GetAutomatedTestAssignmentRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}/relationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetAutomatedTestAssignmentRelationshipsAsync(string id)
        {
            var operation = Operations.GetAutomatedTestAssignmentRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}/runs'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<AutomatedTestRun> GetRunsForAutomatedTestAssignment(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRunsForAutomatedTestAssignment(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AutomatedTestRun>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}/runs'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AutomatedTestRun>> GetRunsForAutomatedTestAssignmentAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRunsForAutomatedTestAssignment(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AutomatedTestRun>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtestassignment/{id}/runs'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual BackgroundTask CreateAutomatedTestRun(string id)
        {
            var operation = Operations.CreateAutomatedTestRun(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<BackgroundTask>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestassignment/{id}/runs'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<BackgroundTask> CreateAutomatedTestRunAsync(string id)
        {
            var operation = Operations.CreateAutomatedTestRun(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<BackgroundTask>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestassignments'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<AutomatedTestAssignment> SearchAutomatedTestAssignments(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAutomatedTestAssignments(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AutomatedTestAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestassignments'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AutomatedTestAssignment>> SearchAutomatedTestAssignmentsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAutomatedTestAssignments(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AutomatedTestAssignment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtestassignments'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AutomatedTestAssignment CreateAutomatedTestAssignment(CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            var operation = Operations.CreateAutomatedTestAssignment(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestAssignment>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestassignments'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestAssignment> CreateAutomatedTestAssignmentAsync(CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            var operation = Operations.CreateAutomatedTestAssignment(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestAssignment>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <returns></returns>
        public virtual AutomatedTestRun GetAutomatedTestRun(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string tql = null, string timeZone = null)
        {
            var operation = Operations.GetAutomatedTestRun(id, top, skip, inlinecount, expand, tql, timeZone);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestRun>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestRun> GetAutomatedTestRunAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string tql = null, string timeZone = null)
        {
            var operation = Operations.GetAutomatedTestRun(id, top, skip, inlinecount, expand, tql, timeZone);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestRun>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteAutomatedTestRun(string id)
        {
            var operation = Operations.DeleteAutomatedTestRun(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteAutomatedTestRunAsync(string id)
        {
            var operation = Operations.DeleteAutomatedTestRun(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{id}/testdata'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual AutomatedTestRunDataTables GetAutomatedTestRunData(string id)
        {
            var operation = Operations.GetAutomatedTestRunData(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestRunDataTables>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{id}/testdata'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestRunDataTables> GetAutomatedTestRunDataAsync(string id)
        {
            var operation = Operations.GetAutomatedTestRunData(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestRunDataTables>();
			return result;
						
		}


        /// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/attachment/{attachmentId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="attachmentId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteAutomatedTestRunAttachment(string runId, string attachmentId)
        {
            var operation = Operations.DeleteAutomatedTestRunAttachment(runId, attachmentId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/attachment/{attachmentId}'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="attachmentId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteAutomatedTestRunAttachmentAsync(string runId, string attachmentId)
        {
            var operation = Operations.DeleteAutomatedTestRunAttachment(runId, attachmentId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/attachments'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<AutomatedTestRunAttachment> GetAutomatedTestRunAttachments(string runId)
        {
            var operation = Operations.GetAutomatedTestRunAttachments(runId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<AutomatedTestRunAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<AutomatedTestRunAttachment>> GetAutomatedTestRunAttachmentsAsync(string runId)
        {
            var operation = Operations.GetAutomatedTestRunAttachments(runId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<AutomatedTestRunAttachment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/attachments'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<AutomatedTestRunAttachment> CreateAutomatedTestRunAttachments(string runId)
        {
            var operation = Operations.CreateAutomatedTestRunAttachments(runId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<AutomatedTestRunAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<AutomatedTestRunAttachment>> CreateAutomatedTestRunAttachmentsAsync(string runId)
        {
            var operation = Operations.CreateAutomatedTestRunAttachments(runId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<AutomatedTestRunAttachment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ResultNode GetAutomatedTestRunNode(string runId, string nodeId, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunNode(runId, nodeId, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ResultNode>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ResultNode> GetAutomatedTestRunNodeAsync(string runId, string nodeId, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunNode(runId, nodeId, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ResultNode>();
			return result;
						
		}

        /// <summary>
        /// Sends a PATCH to '/api/automatedtestrun/{runId}/node/{nodeId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ResultNode PatchAutomatedTestRunNode(string runId, string nodeId, EditResultNode model, string expand = null)
        {
            var operation = Operations.PatchAutomatedTestRunNode(runId, nodeId, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ResultNode>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PATCH to '/api/automatedtestrun/{runId}/node/{nodeId}'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ResultNode> PatchAutomatedTestRunNodeAsync(string runId, string nodeId, EditResultNode model, string expand = null)
        {
            var operation = Operations.PatchAutomatedTestRunNode(runId, nodeId, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ResultNode>();
			return result;
						
		}


        /// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/node/{nodeId}/attachment/{attachmentId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="attachmentId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteAutomatedTestRunNodeAttachment(string runId, string nodeId, string attachmentId)
        {
            var operation = Operations.DeleteAutomatedTestRunNodeAttachment(runId, nodeId, attachmentId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/node/{nodeId}/attachment/{attachmentId}'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="attachmentId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteAutomatedTestRunNodeAttachmentAsync(string runId, string nodeId, string attachmentId)
        {
            var operation = Operations.DeleteAutomatedTestRunNodeAttachment(runId, nodeId, attachmentId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/attachments'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<AutomatedTestRunNodeAttachment> GetAutomatedTestRunNodeAttachments(string runId, string nodeId)
        {
            var operation = Operations.GetAutomatedTestRunNodeAttachments(runId, nodeId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<AutomatedTestRunNodeAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<AutomatedTestRunNodeAttachment>> GetAutomatedTestRunNodeAttachmentsAsync(string runId, string nodeId)
        {
            var operation = Operations.GetAutomatedTestRunNodeAttachments(runId, nodeId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<AutomatedTestRunNodeAttachment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/node/{nodeId}/attachments'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<AutomatedTestRunNodeAttachment> CreateAutomatedTestRunNodeAttachments(string runId, string nodeId)
        {
            var operation = Operations.CreateAutomatedTestRunNodeAttachments(runId, nodeId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<AutomatedTestRunNodeAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/node/{nodeId}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<AutomatedTestRunNodeAttachment>> CreateAutomatedTestRunNodeAttachmentsAsync(string runId, string nodeId)
        {
            var operation = Operations.CreateAutomatedTestRunNodeAttachments(runId, nodeId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<AutomatedTestRunNodeAttachment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/children'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="statuses">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual List<ResultNode> GetAutomatedTestRunNodeChildren(string runId, string nodeId, string statuses, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunNodeChildren(runId, nodeId, statuses, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<ResultNode>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/children'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="statuses">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<List<ResultNode>> GetAutomatedTestRunNodeChildrenAsync(string runId, string nodeId, string statuses, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunNodeChildren(runId, nodeId, statuses, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<ResultNode>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/incident/{incidentId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="incidentId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AutomatedTestRunIncident GetAutomatedTestRunNodeIncident(string runId, string nodeId, string incidentId, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunNodeIncident(runId, nodeId, incidentId, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestRunIncident>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/incident/{incidentId}'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="incidentId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestRunIncident> GetAutomatedTestRunNodeIncidentAsync(string runId, string nodeId, string incidentId, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunNodeIncident(runId, nodeId, incidentId, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestRunIncident>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/node/{nodeId}/incident/{incidentId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="incidentId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteAutomatedTestRunNodeIncident(string runId, string nodeId, string incidentId)
        {
            var operation = Operations.DeleteAutomatedTestRunNodeIncident(runId, nodeId, incidentId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/node/{nodeId}/incident/{incidentId}'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="incidentId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteAutomatedTestRunNodeIncidentAsync(string runId, string nodeId, string incidentId)
        {
            var operation = Operations.DeleteAutomatedTestRunNodeIncident(runId, nodeId, incidentId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/incidents'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual List<AutomatedTestRunIncident> GetAutomatedTestRunNodeIncidents(string runId, string nodeId, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunNodeIncidents(runId, nodeId, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<AutomatedTestRunIncident>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/incidents'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<List<AutomatedTestRunIncident>> GetAutomatedTestRunNodeIncidentsAsync(string runId, string nodeId, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunNodeIncidents(runId, nodeId, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<AutomatedTestRunIncident>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/node/{nodeId}/incidents'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual AutomatedTestRunIncident CreateAutomatedTestRunNodeIncident(string runId, string nodeId, CreateAutomatedTestRunResultNodeIncident model)
        {
            var operation = Operations.CreateAutomatedTestRunNodeIncident(runId, nodeId, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestRunIncident>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/node/{nodeId}/incidents'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestRunIncident> CreateAutomatedTestRunNodeIncidentAsync(string runId, string nodeId, CreateAutomatedTestRunResultNodeIncident model)
        {
            var operation = Operations.CreateAutomatedTestRunNodeIncident(runId, nodeId, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestRunIncident>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/nodes'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual List<ResultNode> GetAutomatedTestRunRootNodes(string runId, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunRootNodes(runId, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<ResultNode>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/nodes'  (asynchronous)
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<List<ResultNode>> GetAutomatedTestRunRootNodesAsync(string runId, string expand = null)
        {
            var operation = Operations.GetAutomatedTestRunRootNodes(runId, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<ResultNode>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestruns'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<AutomatedTestRun> SearchAutomatedTestRuns(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAutomatedTestRuns(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AutomatedTestRun>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestruns'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AutomatedTestRun>> SearchAutomatedTestRunsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAutomatedTestRuns(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AutomatedTestRun>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtests'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<AutomatedTest> SearchAutomatedTests(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAutomatedTests(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AutomatedTest>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtests'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AutomatedTest>> SearchAutomatedTestsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchAutomatedTests(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AutomatedTest>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtests'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual AutomatedTest CreateAutomatedTest(CreateOrUpdateAutomatedTest model, string expand = null)
        {
            var operation = Operations.CreateAutomatedTest(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTest>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtests'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTest> CreateAutomatedTestAsync(CreateOrUpdateAutomatedTest model, string expand = null)
        {
            var operation = Operations.CreateAutomatedTest(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTest>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Schedule GetAutomatedTestScheduleById(string id)
        {
            var operation = Operations.GetAutomatedTestScheduleById(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Schedule>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Schedule> GetAutomatedTestScheduleByIdAsync(string id)
        {
            var operation = Operations.GetAutomatedTestScheduleById(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Schedule>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual Schedule UpdateAutomatedTestSchedule(string id, EditScheduleDTO dto)
        {
            var operation = Operations.UpdateAutomatedTestSchedule(id, dto);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Schedule>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Schedule> UpdateAutomatedTestScheduleAsync(string id, EditScheduleDTO dto)
        {
            var operation = Operations.UpdateAutomatedTestSchedule(id, dto);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Schedule>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeletedAutomatedTestSchedule(string id)
        {
            var operation = Operations.DeletedAutomatedTestSchedule(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeletedAutomatedTestScheduleAsync(string id)
        {
            var operation = Operations.DeletedAutomatedTestSchedule(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{id}/importconfigurations'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ScheduleImportConfiguration> GetAutomatedTestScheduleConfigurations(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAutomatedTestScheduleConfigurations(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ScheduleImportConfiguration>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{id}/importconfigurations'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ScheduleImportConfiguration>> GetAutomatedTestScheduleConfigurationsAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAutomatedTestScheduleConfigurations(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ScheduleImportConfiguration>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{id}/importconfigurations'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual ScheduleImportConfiguration CreateAutomatedTestScheduleConfiguration(string id, EditScheduleConfigurationDTO dto)
        {
            var operation = Operations.CreateAutomatedTestScheduleConfiguration(id, dto);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScheduleImportConfiguration>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{id}/importconfigurations'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<ScheduleImportConfiguration> CreateAutomatedTestScheduleConfigurationAsync(string id, EditScheduleConfigurationDTO dto)
        {
            var operation = Operations.CreateAutomatedTestScheduleConfiguration(id, dto);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScheduleImportConfiguration>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{id}/schedules'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<AutomatedTestingScheduleInfo> GetAutomatedTestScheduleScheduleConfigurations(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAutomatedTestScheduleScheduleConfigurations(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AutomatedTestingScheduleInfo>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{id}/schedules'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AutomatedTestingScheduleInfo>> GetAutomatedTestScheduleScheduleConfigurationsAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAutomatedTestScheduleScheduleConfigurations(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AutomatedTestingScheduleInfo>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{id}/schedules'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual AutomatedTestingScheduleInfo CreateAutomatedTestScheduleScheduleConfiguration(string id, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            var operation = Operations.CreateAutomatedTestScheduleScheduleConfiguration(id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestingScheduleInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{id}/schedules'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestingScheduleInfo> CreateAutomatedTestScheduleScheduleConfigurationAsync(string id, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            var operation = Operations.CreateAutomatedTestScheduleScheduleConfiguration(id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestingScheduleInfo>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual ScheduleImportConfiguration GetConfigurationForAutomatedTestSchedule(string scheduleId, string configId)
        {
            var operation = Operations.GetConfigurationForAutomatedTestSchedule(scheduleId, configId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScheduleImportConfiguration>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<ScheduleImportConfiguration> GetConfigurationForAutomatedTestScheduleAsync(string scheduleId, string configId)
        {
            var operation = Operations.GetConfigurationForAutomatedTestSchedule(scheduleId, configId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScheduleImportConfiguration>();
			return result;
						
		}

        /// <summary>
        /// Sends a PATCH to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual ScheduleImportConfiguration PatchConfigurationForAutomatedTestSchedule(string scheduleId, string configId, PatchScheduleConfigurationDTO dto)
        {
            var operation = Operations.PatchConfigurationForAutomatedTestSchedule(scheduleId, configId, dto);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScheduleImportConfiguration>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PATCH to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<ScheduleImportConfiguration> PatchConfigurationForAutomatedTestScheduleAsync(string scheduleId, string configId, PatchScheduleConfigurationDTO dto)
        {
            var operation = Operations.PatchConfigurationForAutomatedTestSchedule(scheduleId, configId, dto);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScheduleImportConfiguration>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual ScheduleImportConfiguration UpdateConfigurationForAutomatedTestSchedule(string scheduleId, string configId, EditScheduleConfigurationDTO dto)
        {
            var operation = Operations.UpdateConfigurationForAutomatedTestSchedule(scheduleId, configId, dto);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScheduleImportConfiguration>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<ScheduleImportConfiguration> UpdateConfigurationForAutomatedTestScheduleAsync(string scheduleId, string configId, EditScheduleConfigurationDTO dto)
        {
            var operation = Operations.UpdateConfigurationForAutomatedTestSchedule(scheduleId, configId, dto);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScheduleImportConfiguration>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteConfigurationForAutomatedTestSchedule(string scheduleId, string configId)
        {
            var operation = Operations.DeleteConfigurationForAutomatedTestSchedule(scheduleId, configId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteConfigurationForAutomatedTestScheduleAsync(string scheduleId, string configId)
        {
            var operation = Operations.DeleteConfigurationForAutomatedTestSchedule(scheduleId, configId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual AutomatedTestingScheduleInfo GetAutomatedTestScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId)
        {
            var operation = Operations.GetAutomatedTestScheduleScheduleConfiguration(scheduleId, scheduleConfigId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestingScheduleInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestingScheduleInfo> GetAutomatedTestScheduleScheduleConfigurationAsync(string scheduleId, string scheduleConfigId)
        {
            var operation = Operations.GetAutomatedTestScheduleScheduleConfiguration(scheduleId, scheduleConfigId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestingScheduleInfo>();
			return result;
						
		}

        /// <summary>
        /// Sends a PATCH to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual AutomatedTestingScheduleInfo PatchAutomatedTestScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            var operation = Operations.PatchAutomatedTestScheduleScheduleConfiguration(scheduleId, scheduleConfigId, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestingScheduleInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PATCH to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestingScheduleInfo> PatchAutomatedTestScheduleScheduleConfigurationAsync(string scheduleId, string scheduleConfigId, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            var operation = Operations.PatchAutomatedTestScheduleScheduleConfiguration(scheduleId, scheduleConfigId, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestingScheduleInfo>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual AutomatedTestingScheduleInfo UpdateAutomatedTestScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            var operation = Operations.UpdateAutomatedTestScheduleScheduleConfiguration(scheduleId, scheduleConfigId, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestingScheduleInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestingScheduleInfo> UpdateAutomatedTestScheduleScheduleConfigurationAsync(string scheduleId, string scheduleConfigId, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            var operation = Operations.UpdateAutomatedTestScheduleScheduleConfiguration(scheduleId, scheduleConfigId, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestingScheduleInfo>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteAutomatedTestScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId)
        {
            var operation = Operations.DeleteAutomatedTestScheduleScheduleConfiguration(scheduleId, scheduleConfigId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteAutomatedTestScheduleScheduleConfigurationAsync(string scheduleId, string scheduleConfigId)
        {
            var operation = Operations.DeleteAutomatedTestScheduleScheduleConfiguration(scheduleId, scheduleConfigId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}/run'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage TriggerAutomatedScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId)
        {
            var operation = Operations.TriggerAutomatedScheduleScheduleConfiguration(scheduleId, scheduleConfigId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}/run'  (asynchronous)
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> TriggerAutomatedScheduleScheduleConfigurationAsync(string scheduleId, string scheduleConfigId)
        {
            var operation = Operations.TriggerAutomatedScheduleScheduleConfiguration(scheduleId, scheduleConfigId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedules'
        /// </summary>
        /// <param name="projectId">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual QueryResults<Schedule> GetAutomatedTestSchedules(string projectId = null)
        {
            var operation = Operations.GetAutomatedTestSchedules(projectId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Schedule>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtestschedules'  (asynchronous)
        /// </summary>
        /// <param name="projectId">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Schedule>> GetAutomatedTestSchedulesAsync(string projectId = null)
        {
            var operation = Operations.GetAutomatedTestSchedules(projectId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Schedule>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/automatedtestschedules'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual Schedule CreateAutomatedTestSchedule(CreateSchedule model)
        {
            var operation = Operations.CreateAutomatedTestSchedule(model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Schedule>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/automatedtestschedules'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Schedule> CreateAutomatedTestScheduleAsync(CreateSchedule model)
        {
            var operation = Operations.CreateAutomatedTestSchedule(model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Schedule>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtesttype/{name}'
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual AutomatedTestType GetAutomatedTestTypeByName(string name)
        {
            var operation = Operations.GetAutomatedTestTypeByName(name);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<AutomatedTestType>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtesttype/{name}'  (asynchronous)
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<AutomatedTestType> GetAutomatedTestTypeByNameAsync(string name)
        {
            var operation = Operations.GetAutomatedTestTypeByName(name);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<AutomatedTestType>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/automatedtesttypes'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<AutomatedTestType> GetAutomatedTestTypes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAutomatedTestTypes(top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<AutomatedTestType>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/automatedtesttypes'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<AutomatedTestType>> GetAutomatedTestTypesAsync(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAutomatedTestTypes(top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<AutomatedTestType>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/backgroundtask/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual BackgroundTask GetBackgroundTaskStatus(string id)
        {
            var operation = Operations.GetBackgroundTaskStatus(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<BackgroundTask>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/backgroundtask/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<BackgroundTask> GetBackgroundTaskStatusAsync(string id)
        {
            var operation = Operations.GetBackgroundTaskStatus(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<BackgroundTask>();
			return result;
						
		}


        /// <summary>
        /// Sends a POST to '/api/backgroundtasks'
        /// </summary>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual BackgroundTask StartBackgroundTask(CreateBackgroundTask dto)
        {
            var operation = Operations.StartBackgroundTask(dto);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<BackgroundTask>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/backgroundtasks'  (asynchronous)
        /// </summary>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<BackgroundTask> StartBackgroundTaskAsync(CreateBackgroundTask dto)
        {
            var operation = Operations.StartBackgroundTask(dto);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<BackgroundTask>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/customfield/{name}'
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual CustomField GetCustomField(string name)
        {
            var operation = Operations.GetCustomField(name);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<CustomField>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/customfield/{name}'  (asynchronous)
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<CustomField> GetCustomFieldAsync(string name)
        {
            var operation = Operations.GetCustomField(name);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<CustomField>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/customfields'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<CustomField> SearchCustomFields(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchCustomFields(top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<CustomField>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/customfields'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<CustomField>> SearchCustomFieldsAsync(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchCustomFields(top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<CustomField>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/customfieldtype/{name}'
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual CustomFieldType GetCustomFieldType(string name)
        {
            var operation = Operations.GetCustomFieldType(name);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<CustomFieldType>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/customfieldtype/{name}'  (asynchronous)
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<CustomFieldType> GetCustomFieldTypeAsync(string name)
        {
            var operation = Operations.GetCustomFieldType(name);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<CustomFieldType>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/customfieldtypes'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<CustomFieldType> SearchCustomFieldTypes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchCustomFieldTypes(top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<CustomFieldType>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/customfieldtypes'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<CustomFieldType>> SearchCustomFieldTypesAsync(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchCustomFieldTypes(top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<CustomFieldType>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/diagnostics/performancemeasurement/latest'
        /// </summary>
        /// <param name="export">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage GetLastPerformanceTestResults(bool? export = null)
        {
            var operation = Operations.GetLastPerformanceTestResults(export);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a GET to '/api/diagnostics/performancemeasurement/latest'  (asynchronous)
        /// </summary>
        /// <param name="export">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> GetLastPerformanceTestResultsAsync(bool? export = null)
        {
            var operation = Operations.GetLastPerformanceTestResults(export);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/executionpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExecutionPackage GetExecutionPackage(string id, string expand = null)
        {
            var operation = Operations.GetExecutionPackage(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExecutionPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/executionpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExecutionPackage> GetExecutionPackageAsync(string id, string expand = null)
        {
            var operation = Operations.GetExecutionPackage(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExecutionPackage>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/executionpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExecutionPackage UpdateExecutionPackage(string id, CreateOrUpdateExecutionPackage model, string expand = null)
        {
            var operation = Operations.UpdateExecutionPackage(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExecutionPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/executionpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExecutionPackage> UpdateExecutionPackageAsync(string id, CreateOrUpdateExecutionPackage model, string expand = null)
        {
            var operation = Operations.UpdateExecutionPackage(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExecutionPackage>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/executionpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteExecutionPackage(string id)
        {
            var operation = Operations.DeleteExecutionPackage(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/executionpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteExecutionPackageAsync(string id)
        {
            var operation = Operations.DeleteExecutionPackage(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/executionpackage/{id}/children'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ExecutionPackage> GetExecutionPackageChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetExecutionPackageChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ExecutionPackage>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/executionpackage/{id}/children'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ExecutionPackage>> GetExecutionPackageChildrenAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetExecutionPackageChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ExecutionPackage>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/executionpackages'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<ExecutionPackage> SearchExecutionPackages(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchExecutionPackages(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ExecutionPackage>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/executionpackages'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ExecutionPackage>> SearchExecutionPackagesAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchExecutionPackages(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ExecutionPackage>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/executionpackages'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExecutionPackage CreateExecutionPackage(CreateOrUpdateExecutionPackage model, string expand = null)
        {
            var operation = Operations.CreateExecutionPackage(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExecutionPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/executionpackages'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExecutionPackage> CreateExecutionPackageAsync(CreateOrUpdateExecutionPackage model, string expand = null)
        {
            var operation = Operations.CreateExecutionPackage(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExecutionPackage>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/exportfile/{filename}'
        /// </summary>
        /// <param name="filename">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage GetExportedFileContents(string filename)
        {
            var operation = Operations.GetExportedFileContents(filename);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a GET to '/api/exportfile/{filename}'  (asynchronous)
        /// </summary>
        /// <param name="filename">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> GetExportedFileContentsAsync(string filename)
        {
            var operation = Operations.GetExportedFileContents(filename);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsourcemetadata'
        /// </summary>
        /// <param name="end">a query parameter (no description)</param>
        /// <param name="key">a query parameter (no description)</param>
        /// <param name="id">a query parameter (no description)</param>
        /// <param name="projectId">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExternalSourceMetadata GetExternalSourceByAttributes(string end = null, string key = null, string id = null, string projectId = null, string expand = null)
        {
            var operation = Operations.GetExternalSourceByAttributes(end, key, id, projectId, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSourceMetadata>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsourcemetadata'  (asynchronous)
        /// </summary>
        /// <param name="end">a query parameter (no description)</param>
        /// <param name="key">a query parameter (no description)</param>
        /// <param name="id">a query parameter (no description)</param>
        /// <param name="projectId">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSourceMetadata> GetExternalSourceByAttributesAsync(string end = null, string key = null, string id = null, string projectId = null, string expand = null)
        {
            var operation = Operations.GetExternalSourceByAttributes(end, key, id, projectId, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSourceMetadata>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsourcesmetadata'
        /// </summary>
        /// <param name="compatibleWithKey">a query parameter (no description)</param>
        /// <param name="end">a query parameter (no description)</param>
        /// <param name="compatibleWithId">a query parameter (no description)</param>
        /// <param name="projectId">a query parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ExternalSourceMetadata> SearchExternalSources(string compatibleWithKey = null, string end = null, string compatibleWithId = null, string projectId = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchExternalSources(compatibleWithKey, end, compatibleWithId, projectId, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ExternalSourceMetadata>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsourcesmetadata'  (asynchronous)
        /// </summary>
        /// <param name="compatibleWithKey">a query parameter (no description)</param>
        /// <param name="end">a query parameter (no description)</param>
        /// <param name="compatibleWithId">a query parameter (no description)</param>
        /// <param name="projectId">a query parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ExternalSourceMetadata>> SearchExternalSourcesAsync(string compatibleWithKey = null, string end = null, string compatibleWithId = null, string projectId = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchExternalSources(compatibleWithKey, end, compatibleWithId, projectId, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ExternalSourceMetadata>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystem/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExternalSystem GetExternalSystem(string id, string expand = null)
        {
            var operation = Operations.GetExternalSystem(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSystem>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystem/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSystem> GetExternalSystemAsync(string id, string expand = null)
        {
            var operation = Operations.GetExternalSystem(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSystem>();
			return result;
						
		}

        /// <summary>
        /// Sends a PATCH to '/api/externalsystem/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExternalSystem PatchExternalSystem(string id, CreateOrUpdateExternalSystem model, string expand = null)
        {
            var operation = Operations.PatchExternalSystem(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSystem>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PATCH to '/api/externalsystem/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSystem> PatchExternalSystemAsync(string id, CreateOrUpdateExternalSystem model, string expand = null)
        {
            var operation = Operations.PatchExternalSystem(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSystem>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/externalsystem/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExternalSystem UpdateExternalSystem(string id, CreateOrUpdateExternalSystem model, string expand = null)
        {
            var operation = Operations.UpdateExternalSystem(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSystem>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/externalsystem/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSystem> UpdateExternalSystemAsync(string id, CreateOrUpdateExternalSystem model, string expand = null)
        {
            var operation = Operations.UpdateExternalSystem(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSystem>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/externalsystem/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="keepReferences">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteExternalSystem(string id, bool? keepReferences = null)
        {
            var operation = Operations.DeleteExternalSystem(id, keepReferences);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/externalsystem/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="keepReferences">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteExternalSystemAsync(string id, bool? keepReferences = null)
        {
            var operation = Operations.DeleteExternalSystem(id, keepReferences);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystem/{systemId}/links'
        /// </summary>
        /// <param name="systemId">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ExternalSystemLink> GetExternalSystemLinksForSystem(string systemId, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetExternalSystemLinksForSystem(systemId, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ExternalSystemLink>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystem/{systemId}/links'  (asynchronous)
        /// </summary>
        /// <param name="systemId">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ExternalSystemLink>> GetExternalSystemLinksForSystemAsync(string systemId, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetExternalSystemLinksForSystem(systemId, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ExternalSystemLink>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystemlink/{externalSystemLinkId}/ticket/{ticketId}'
        /// </summary>
        /// <param name="ticketId">a path parameter (no description)</param>
        /// <param name="externalSystemLinkId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual TicketSearchResult GetTicket(string ticketId, string externalSystemLinkId, string expand = null)
        {
            var operation = Operations.GetTicket(ticketId, externalSystemLinkId, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<TicketSearchResult>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystemlink/{externalSystemLinkId}/ticket/{ticketId}'  (asynchronous)
        /// </summary>
        /// <param name="ticketId">a path parameter (no description)</param>
        /// <param name="externalSystemLinkId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<TicketSearchResult> GetTicketAsync(string ticketId, string externalSystemLinkId, string expand = null)
        {
            var operation = Operations.GetTicket(ticketId, externalSystemLinkId, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<TicketSearchResult>();
			return result;
						
		}


        /// <summary>
        /// Sends a POST to '/api/externalsystemlink/{externalSystemLinkId}/ticket/{ticketId}/link'
        /// </summary>
        /// <param name="ticketId">a path parameter (no description)</param>
        /// <param name="externalSystemLinkId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual BackgroundTask StartCreateIncidentFromTicket(string ticketId, string externalSystemLinkId)
        {
            var operation = Operations.StartCreateIncidentFromTicket(ticketId, externalSystemLinkId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<BackgroundTask>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/externalsystemlink/{externalSystemLinkId}/ticket/{ticketId}/link'  (asynchronous)
        /// </summary>
        /// <param name="ticketId">a path parameter (no description)</param>
        /// <param name="externalSystemLinkId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<BackgroundTask> StartCreateIncidentFromTicketAsync(string ticketId, string externalSystemLinkId)
        {
            var operation = Operations.StartCreateIncidentFromTicket(ticketId, externalSystemLinkId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<BackgroundTask>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystemlink/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExternalSystemLink GetExternalSystemLink(string id, string expand = null)
        {
            var operation = Operations.GetExternalSystemLink(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSystemLink>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystemlink/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSystemLink> GetExternalSystemLinkAsync(string id, string expand = null)
        {
            var operation = Operations.GetExternalSystemLink(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSystemLink>();
			return result;
						
		}

        /// <summary>
        /// Sends a PATCH to '/api/externalsystemlink/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual ExternalSystemLink PatchExternalSystemLink(string id, EditExternalSystemLink model)
        {
            var operation = Operations.PatchExternalSystemLink(id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSystemLink>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PATCH to '/api/externalsystemlink/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSystemLink> PatchExternalSystemLinkAsync(string id, EditExternalSystemLink model)
        {
            var operation = Operations.PatchExternalSystemLink(id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSystemLink>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/externalsystemlink/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="keepReferences">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteExternalSystemLink(string id, bool? keepReferences = null)
        {
            var operation = Operations.DeleteExternalSystemLink(id, keepReferences);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/externalsystemlink/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="keepReferences">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteExternalSystemLinkAsync(string id, bool? keepReferences = null)
        {
            var operation = Operations.DeleteExternalSystemLink(id, keepReferences);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystemlink/{linkId}/field/{fieldName}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="fieldName">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual QueryResults<IValue> GetOptionsForExternalSystemLinksField(string linkId, string fieldName, string query = null, bool? valuesqry = null)
        {
            var operation = Operations.GetOptionsForExternalSystemLinksField(linkId, fieldName, query, valuesqry);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<IValue>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystemlink/{linkId}/field/{fieldName}'  (asynchronous)
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="fieldName">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<IValue>> GetOptionsForExternalSystemLinksFieldAsync(string linkId, string fieldName, string query = null, bool? valuesqry = null)
        {
            var operation = Operations.GetOptionsForExternalSystemLinksField(linkId, fieldName, query, valuesqry);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<IValue>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystemlinks'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ExternalSystemLink> SearchExternalSystemLinks(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchExternalSystemLinks(top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ExternalSystemLink>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystemlinks'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ExternalSystemLink>> SearchExternalSystemLinksAsync(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchExternalSystemLinks(top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ExternalSystemLink>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/externalsystemlinks'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExternalSystemLink CreateExternalSystemLink(CreateExternalSystemLink model, string expand = null)
        {
            var operation = Operations.CreateExternalSystemLink(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSystemLink>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/externalsystemlinks'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSystemLink> CreateExternalSystemLinkAsync(CreateExternalSystemLink model, string expand = null)
        {
            var operation = Operations.CreateExternalSystemLink(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSystemLink>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystems'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ExternalSystem> SearchExternalSystems(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchExternalSystems(top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ExternalSystem>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystems'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ExternalSystem>> SearchExternalSystemsAsync(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchExternalSystems(top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ExternalSystem>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/externalsystems'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ExternalSystem CreateExternalSystem(CreateOrUpdateExternalSystem model, string expand = null)
        {
            var operation = Operations.CreateExternalSystem(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSystem>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/externalsystems'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSystem> CreateExternalSystemAsync(CreateOrUpdateExternalSystem model, string expand = null)
        {
            var operation = Operations.CreateExternalSystem(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSystem>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystemtype/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual ExternalSystemType GetExternalSystemType(string id)
        {
            var operation = Operations.GetExternalSystemType(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ExternalSystemType>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystemtype/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<ExternalSystemType> GetExternalSystemTypeAsync(string id)
        {
            var operation = Operations.GetExternalSystemType(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ExternalSystemType>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/externalsystemtypes'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ExternalSystemType> SearchExternalSystemTypes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchExternalSystemTypes(top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ExternalSystemType>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/externalsystemtypes'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ExternalSystemType>> SearchExternalSystemTypesAsync(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchExternalSystemTypes(top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ExternalSystemType>>();
			return result;
						
		}


        /// <summary>
        /// Sends a POST to '/api/gridwidget/{widgetType}/data/{dataName}'
        /// </summary>
        /// <param name="widgetType">a path parameter (no description)</param>
        /// <param name="dataName">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual GridWidgetData GetGridWidgetData(string widgetType, string dataName, GridWidgetContext model)
        {
            var operation = Operations.GetGridWidgetData(widgetType, dataName, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<GridWidgetData>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/gridwidget/{widgetType}/data/{dataName}'  (asynchronous)
        /// </summary>
        /// <param name="widgetType">a path parameter (no description)</param>
        /// <param name="dataName">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<GridWidgetData> GetGridWidgetDataAsync(string widgetType, string dataName, GridWidgetContext model)
        {
            var operation = Operations.GetGridWidgetData(widgetType, dataName, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<GridWidgetData>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/gridwidgethost/{hostId}/project/{projectId}/position/{position}'
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="position">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual GridWidgetState GetGridWidgetState(string hostId, string projectId, string position)
        {
            var operation = Operations.GetGridWidgetState(hostId, projectId, position);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<GridWidgetState>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/gridwidgethost/{hostId}/project/{projectId}/position/{position}'  (asynchronous)
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="position">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<GridWidgetState> GetGridWidgetStateAsync(string hostId, string projectId, string position)
        {
            var operation = Operations.GetGridWidgetState(hostId, projectId, position);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<GridWidgetState>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/gridwidgethost/{hostId}/project/{projectId}/position/{position}'
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="position">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual GridWidgetState UpdateGridWidgetState(string hostId, string projectId, string position, EditGridWidgetState model)
        {
            var operation = Operations.UpdateGridWidgetState(hostId, projectId, position, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<GridWidgetState>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/gridwidgethost/{hostId}/project/{projectId}/position/{position}'  (asynchronous)
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="position">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<GridWidgetState> UpdateGridWidgetStateAsync(string hostId, string projectId, string position, EditGridWidgetState model)
        {
            var operation = Operations.UpdateGridWidgetState(hostId, projectId, position, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<GridWidgetState>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/gridwidgethost/{hostId}/project/{projectId}/positions'
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual GridWidgetStateSet GetGridWidgetStatesForHost(string hostId, string projectId)
        {
            var operation = Operations.GetGridWidgetStatesForHost(hostId, projectId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<GridWidgetStateSet>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/gridwidgethost/{hostId}/project/{projectId}/positions'  (asynchronous)
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<GridWidgetStateSet> GetGridWidgetStatesForHostAsync(string hostId, string projectId)
        {
            var operation = Operations.GetGridWidgetStatesForHost(hostId, projectId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<GridWidgetStateSet>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/group/{groupId}/permissions/project/{projectId}'
        /// </summary>
        /// <param name="groupId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<PermissionAssignment> GetGroupProjectPermissions(string groupId, string projectId)
        {
            var operation = Operations.GetGroupProjectPermissions(groupId, projectId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<PermissionAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/group/{groupId}/permissions/project/{projectId}'  (asynchronous)
        /// </summary>
        /// <param name="groupId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<PermissionAssignment>> GetGroupProjectPermissionsAsync(string groupId, string projectId)
        {
            var operation = Operations.GetGroupProjectPermissions(groupId, projectId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<PermissionAssignment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/group/{groupId}/permissions/project/{projectId}'
        /// </summary>
        /// <param name="groupId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual List<PermissionAssignment> UpdateGroupProjectPermissions(string groupId, string projectId, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            var operation = Operations.UpdateGroupProjectPermissions(groupId, projectId, assignments);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<PermissionAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/group/{groupId}/permissions/project/{projectId}'  (asynchronous)
        /// </summary>
        /// <param name="groupId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<PermissionAssignment>> UpdateGroupProjectPermissionsAsync(string groupId, string projectId, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            var operation = Operations.UpdateGroupProjectPermissions(groupId, projectId, assignments);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<PermissionAssignment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/group/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Group GetGroup(string id, string expand = null)
        {
            var operation = Operations.GetGroup(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Group>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/group/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Group> GetGroupAsync(string id, string expand = null)
        {
            var operation = Operations.GetGroup(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Group>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/group/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual Group UpdateGroup(string id, CreateOrUpdateGroup model)
        {
            var operation = Operations.UpdateGroup(id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Group>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/group/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Group> UpdateGroupAsync(string id, CreateOrUpdateGroup model)
        {
            var operation = Operations.UpdateGroup(id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Group>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/group/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteGroup(string id)
        {
            var operation = Operations.DeleteGroup(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/group/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteGroupAsync(string id)
        {
            var operation = Operations.DeleteGroup(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/group/{id}/permissions/global'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<PermissionAssignment> GetGlobalGroupPermissions(string id)
        {
            var operation = Operations.GetGlobalGroupPermissions(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<PermissionAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/group/{id}/permissions/global'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<PermissionAssignment>> GetGlobalGroupPermissionsAsync(string id)
        {
            var operation = Operations.GetGlobalGroupPermissions(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<PermissionAssignment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/group/{id}/permissions/global'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual List<PermissionAssignment> UpdateGlobalGroupPermissions(string id, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            var operation = Operations.UpdateGlobalGroupPermissions(id, assignments);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<PermissionAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/group/{id}/permissions/global'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<PermissionAssignment>> UpdateGlobalGroupPermissionsAsync(string id, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            var operation = Operations.UpdateGlobalGroupPermissions(id, assignments);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<PermissionAssignment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/group/{id}/permissions/projects'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual GroupPermissionProjects GetProjectGroupPermissionLinks(string id)
        {
            var operation = Operations.GetProjectGroupPermissionLinks(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<GroupPermissionProjects>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/group/{id}/permissions/projects'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<GroupPermissionProjects> GetProjectGroupPermissionLinksAsync(string id)
        {
            var operation = Operations.GetProjectGroupPermissionLinks(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<GroupPermissionProjects>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/group/{id}/users'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<User> GetGroupMembers(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetGroupMembers(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<User>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/group/{id}/users'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<User>> GetGroupMembersAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetGroupMembers(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<User>>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/group/{id}/users'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<User> SetGroupMembers(string id, GroupMemberships model, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SetGroupMembers(id, model, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<User>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/group/{id}/users'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<User>> SetGroupMembersAsync(string id, GroupMemberships model, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SetGroupMembers(id, model, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<User>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/groups'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<Group> SearchGroups(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchGroups(top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Group>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/groups'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Group>> SearchGroupsAsync(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchGroups(top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Group>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/groups'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual Group CreateGroup(CreateOrUpdateGroup model)
        {
            var operation = Operations.CreateGroup(model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Group>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/groups'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Group> CreateGroupAsync(CreateOrUpdateGroup model)
        {
            var operation = Operations.CreateGroup(model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Group>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/groupssearch'
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<Group> SearchGroupsByPartialName(string query = null, bool? valuesqry = null, string expand = null)
        {
            var operation = Operations.SearchGroupsByPartialName(query, valuesqry, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Group>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/groupssearch'  (asynchronous)
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Group>> SearchGroupsByPartialNameAsync(string query = null, bool? valuesqry = null, string expand = null)
        {
            var operation = Operations.SearchGroupsByPartialName(query, valuesqry, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Group>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/groupssearch'
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage SearchGroupsByPartialNameUsingPostMethod(string valuesqry = null, string query = null, string expand = null)
        {
            var operation = Operations.SearchGroupsByPartialNameUsingPostMethod(valuesqry, query, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/groupssearch'  (asynchronous)
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SearchGroupsByPartialNameUsingPostMethodAsync(string valuesqry = null, string query = null, string expand = null)
        {
            var operation = Operations.SearchGroupsByPartialNameUsingPostMethod(valuesqry, query, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/incident/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Incident GetIncident(string id, string expand = null)
        {
            var operation = Operations.GetIncident(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Incident>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/incident/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Incident> GetIncidentAsync(string id, string expand = null)
        {
            var operation = Operations.GetIncident(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Incident>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/incident/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Incident UpdateIncident(string id, CreateOrUpdateIncident model, string expand = null)
        {
            var operation = Operations.UpdateIncident(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Incident>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/incident/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Incident> UpdateIncidentAsync(string id, CreateOrUpdateIncident model, string expand = null)
        {
            var operation = Operations.UpdateIncident(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Incident>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/incident/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteIncident(string id)
        {
            var operation = Operations.DeleteIncident(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/incident/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteIncidentAsync(string id)
        {
            var operation = Operations.DeleteIncident(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/incident/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetIncidentAllRelationships(string id)
        {
            var operation = Operations.GetIncidentAllRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/incident/{id}/allrelationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetIncidentAllRelationshipsAsync(string id)
        {
            var operation = Operations.GetIncidentAllRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/incident/{id}/comments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<IncidentComment> GetIncidentComments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetIncidentComments(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<IncidentComment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/incident/{id}/comments'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<IncidentComment>> GetIncidentCommentsAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetIncidentComments(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<IncidentComment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/incident/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetIncidentRelationships(string id)
        {
            var operation = Operations.GetIncidentRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/incident/{id}/relationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetIncidentRelationshipsAsync(string id)
        {
            var operation = Operations.GetIncidentRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/incidents'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<Incident> SearchIncidents(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchIncidents(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Incident>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/incidents'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Incident>> SearchIncidentsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchIncidents(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Incident>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/incidents'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Incident CreateIncident(CreateOrUpdateIncident model, string expand = null)
        {
            var operation = Operations.CreateIncident(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Incident>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/incidents'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Incident> CreateIncidentAsync(CreateOrUpdateIncident model, string expand = null)
        {
            var operation = Operations.CreateIncident(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Incident>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/mailqueue/messages'
        /// </summary>
        /// <returns></returns>
        public virtual QueryResults<QueuedMessage> GetQueuedMailMessages()
        {
            var operation = Operations.GetQueuedMailMessages();
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<QueuedMessage>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/mailqueue/messages'  (asynchronous)
        /// </summary>
        /// <returns></returns>
        public virtual async Task<QueryResults<QueuedMessage>> GetQueuedMailMessagesAsync()
        {
            var operation = Operations.GetQueuedMailMessages();
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<QueuedMessage>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/mailsender/default/settings'
        /// </summary>
        /// <returns></returns>
        public virtual MailSenderSettings GetMailSenderSettings()
        {
            var operation = Operations.GetMailSenderSettings();
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<MailSenderSettings>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/mailsender/default/settings'  (asynchronous)
        /// </summary>
        /// <returns></returns>
        public virtual async Task<MailSenderSettings> GetMailSenderSettingsAsync()
        {
            var operation = Operations.GetMailSenderSettings();
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<MailSenderSettings>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/mailsender/default/settings'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual MailSenderSettings UpdateMailSenderSettings(MailSenderSettings model)
        {
            var operation = Operations.UpdateMailSenderSettings(model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<MailSenderSettings>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/mailsender/default/settings'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<MailSenderSettings> UpdateMailSenderSettingsAsync(MailSenderSettings model)
        {
            var operation = Operations.UpdateMailSenderSettings(model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<MailSenderSettings>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/organisation/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Organisation GetOrganisation(string id, string expand = null)
        {
            var operation = Operations.GetOrganisation(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Organisation>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/organisation/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Organisation> GetOrganisationAsync(string id, string expand = null)
        {
            var operation = Operations.GetOrganisation(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Organisation>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/organisation/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Organisation UpdateOrganisation(string id, CreateOrUpdateOrganisation model, string expand = null)
        {
            var operation = Operations.UpdateOrganisation(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Organisation>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/organisation/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Organisation> UpdateOrganisationAsync(string id, CreateOrUpdateOrganisation model, string expand = null)
        {
            var operation = Operations.UpdateOrganisation(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Organisation>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/organisation/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void StartDeleteOrganisation(string id)
        {
            var operation = Operations.StartDeleteOrganisation(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/organisation/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task StartDeleteOrganisationAsync(string id)
        {
            var operation = Operations.StartDeleteOrganisation(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/organisation/{id}/relationshiptype/{key}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual RelationshipType GetRelationshipTypesByKey(string id, string key, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRelationshipTypesByKey(id, key, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<RelationshipType>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/organisation/{id}/relationshiptype/{key}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<RelationshipType> GetRelationshipTypesByKeyAsync(string id, string key, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRelationshipTypesByKey(id, key, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<RelationshipType>();
			return result;
						
		}


        /// <summary>
        /// Sends a POST to '/api/organisation/{id}/relationshiptype/{key}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual Relationship CreateRelationship(string id, string key, CreateRelationship model, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.CreateRelationship(id, key, model, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/organisation/{id}/relationshiptype/{key}/relationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> CreateRelationshipAsync(string id, string key, CreateRelationship model, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.CreateRelationship(id, key, model, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/organisation/{id}/relationshiptypes'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<RelationshipType> GetRelationshipTypes(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRelationshipTypes(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<RelationshipType>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/organisation/{id}/relationshiptypes'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<RelationshipType>> GetRelationshipTypesAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRelationshipTypes(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<RelationshipType>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/picklist/{type}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual QueryResults<Picklist> GetOrganisationPicklistValues(string organisationId, string type)
        {
            var operation = Operations.GetOrganisationPicklistValues(organisationId, type);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Picklist>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/picklist/{type}'  (asynchronous)
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Picklist>> GetOrganisationPicklistValuesAsync(string organisationId, string type)
        {
            var operation = Operations.GetOrganisationPicklistValues(organisationId, type);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Picklist>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/picklistsearch/{type}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual QueryResults<Picklist> SearchOrganisationPicklistValues(string organisationId, string type, string query = null, bool? valuesqry = null)
        {
            var operation = Operations.SearchOrganisationPicklistValues(organisationId, type, query, valuesqry);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Picklist>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/picklistsearch/{type}'  (asynchronous)
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Picklist>> SearchOrganisationPicklistValuesAsync(string organisationId, string type, string query = null, bool? valuesqry = null)
        {
            var operation = Operations.SearchOrganisationPicklistValues(organisationId, type, query, valuesqry);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Picklist>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/organisation/{organisationId}/picklistsearch/{type}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage SearchOrganisationPicklistValuesUsingPostMethod(string organisationId, string type, string valuesqry = null, string query = null)
        {
            var operation = Operations.SearchOrganisationPicklistValuesUsingPostMethod(organisationId, type, valuesqry, query);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/organisation/{organisationId}/picklistsearch/{type}'  (asynchronous)
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SearchOrganisationPicklistValuesUsingPostMethodAsync(string organisationId, string type, string valuesqry = null, string query = null)
        {
            var operation = Operations.SearchOrganisationPicklistValuesUsingPostMethod(organisationId, type, valuesqry, query);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetRelationship(string organisationId, string key, string id)
        {
            var operation = Operations.GetRelationship(organisationId, key, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'  (asynchronous)
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetRelationshipAsync(string organisationId, string key, string id)
        {
            var operation = Operations.GetRelationship(organisationId, key, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship UpdateRelationship(string organisationId, string key, string id, UpdateRelationship model)
        {
            var operation = Operations.UpdateRelationship(organisationId, key, id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'  (asynchronous)
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> UpdateRelationshipAsync(string organisationId, string key, string id, UpdateRelationship model)
        {
            var operation = Operations.UpdateRelationship(organisationId, key, id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteRelationship(string organisationId, string key, string id)
        {
            var operation = Operations.DeleteRelationship(organisationId, key, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'  (asynchronous)
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteRelationshipAsync(string organisationId, string key, string id)
        {
            var operation = Operations.DeleteRelationship(organisationId, key, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/organisations'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<Organisation> SearchOrganisations(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchOrganisations(top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Organisation>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/organisations'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Organisation>> SearchOrganisationsAsync(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchOrganisations(top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Organisation>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/organisations'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage CreateOrganisation(CreateOrUpdateOrganisation model, string expand = null)
        {
            var operation = Operations.CreateOrganisation(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/organisations'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> CreateOrganisationAsync(CreateOrUpdateOrganisation model, string expand = null)
        {
            var operation = Operations.CreateOrganisation(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/permission/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Permission GetPermission(string id)
        {
            var operation = Operations.GetPermission(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Permission>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/permission/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Permission> GetPermissionAsync(string id)
        {
            var operation = Operations.GetPermission(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Permission>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/permissions'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<Permission> GetAllPermissions(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAllPermissions(top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Permission>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/permissions'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Permission>> GetAllPermissionsAsync(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAllPermissions(top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Permission>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/project/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Project GetProject(string id, string expand = null)
        {
            var operation = Operations.GetProject(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Project>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/project/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Project> GetProjectAsync(string id, string expand = null)
        {
            var operation = Operations.GetProject(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Project>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/project/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Project UpdateProject(string id, CreateOrUpdateProject model, string expand = null)
        {
            var operation = Operations.UpdateProject(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Project>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/project/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Project> UpdateProjectAsync(string id, CreateOrUpdateProject model, string expand = null)
        {
            var operation = Operations.UpdateProject(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Project>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/project/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void StartProjectDelete(string id)
        {
            var operation = Operations.StartProjectDelete(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/project/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task StartProjectDeleteAsync(string id)
        {
            var operation = Operations.StartProjectDelete(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/project/{projectId}/assignees'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<User> SearchProjectAssignees(string projectId, string query = null, string expand = null)
        {
            var operation = Operations.SearchProjectAssignees(projectId, query, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<User>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/project/{projectId}/assignees'  (asynchronous)
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<User>> SearchProjectAssigneesAsync(string projectId, string query = null, string expand = null)
        {
            var operation = Operations.SearchProjectAssignees(projectId, query, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<User>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/project/{projectId}/picklist/{type}'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<Picklist> GetProjectPicklistValues(string projectId, string type, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetProjectPicklistValues(projectId, type, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Picklist>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/project/{projectId}/picklist/{type}'  (asynchronous)
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Picklist>> GetProjectPicklistValuesAsync(string projectId, string type, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetProjectPicklistValues(projectId, type, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Picklist>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/project/{projectId}/picklistsearch/{type}'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual QueryResults<Picklist> SearchProjectPicklistValues(string projectId, string type, string query = null, bool? valuesqry = null)
        {
            var operation = Operations.SearchProjectPicklistValues(projectId, type, query, valuesqry);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Picklist>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/project/{projectId}/picklistsearch/{type}'  (asynchronous)
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Picklist>> SearchProjectPicklistValuesAsync(string projectId, string type, string query = null, bool? valuesqry = null)
        {
            var operation = Operations.SearchProjectPicklistValues(projectId, type, query, valuesqry);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Picklist>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/project/{projectId}/picklistsearch/{type}'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage SearchProjectPicklistValuesUsingPostMethod(string projectId, string type, string valuesqry = null, string query = null)
        {
            var operation = Operations.SearchProjectPicklistValuesUsingPostMethod(projectId, type, valuesqry, query);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/project/{projectId}/picklistsearch/{type}'  (asynchronous)
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SearchProjectPicklistValuesUsingPostMethodAsync(string projectId, string type, string valuesqry = null, string query = null)
        {
            var operation = Operations.SearchProjectPicklistValuesUsingPostMethod(projectId, type, valuesqry, query);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/project/{projectId}/tickets'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="q">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<TicketSearchResult> SearchTickets(string projectId, string q = null, string expand = null)
        {
            var operation = Operations.SearchTickets(projectId, q, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<TicketSearchResult>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/project/{projectId}/tickets'  (asynchronous)
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="q">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<TicketSearchResult>> SearchTicketsAsync(string projectId, string q = null, string expand = null)
        {
            var operation = Operations.SearchTickets(projectId, q, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<TicketSearchResult>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/projectcategories'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ProjectCategory> SearchAllProjectCategories(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchAllProjectCategories(top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ProjectCategory>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/projectcategories'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ProjectCategory>> SearchAllProjectCategoriesAsync(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchAllProjectCategories(top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ProjectCategory>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/projectcategories'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ProjectCategory CreateProjectCategory(CreateOrUpdateProjectCategory model, string expand = null)
        {
            var operation = Operations.CreateProjectCategory(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ProjectCategory>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/projectcategories'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ProjectCategory> CreateProjectCategoryAsync(CreateOrUpdateProjectCategory model, string expand = null)
        {
            var operation = Operations.CreateProjectCategory(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ProjectCategory>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/projectcategory/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ProjectCategory GetProjectCategory(string id, string expand = null)
        {
            var operation = Operations.GetProjectCategory(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ProjectCategory>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/projectcategory/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ProjectCategory> GetProjectCategoryAsync(string id, string expand = null)
        {
            var operation = Operations.GetProjectCategory(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ProjectCategory>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/projectcategory/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ProjectCategory UpdateProjectCategory(string id, CreateOrUpdateProjectCategory model, string expand = null)
        {
            var operation = Operations.UpdateProjectCategory(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ProjectCategory>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/projectcategory/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ProjectCategory> UpdateProjectCategoryAsync(string id, CreateOrUpdateProjectCategory model, string expand = null)
        {
            var operation = Operations.UpdateProjectCategory(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ProjectCategory>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/projectcategory/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteProjectCategory(string id)
        {
            var operation = Operations.DeleteProjectCategory(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/projectcategory/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteProjectCategoryAsync(string id)
        {
            var operation = Operations.DeleteProjectCategory(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/projectcategory/{id}/children'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ProjectCategory> GetProjectCategoriesChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetProjectCategoriesChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ProjectCategory>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/projectcategory/{id}/children'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ProjectCategory>> GetProjectCategoriesChildrenAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetProjectCategoriesChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ProjectCategory>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/projects'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<Project> SearchProjects(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchProjects(top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Project>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/projects'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Project>> SearchProjectsAsync(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchProjects(top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Project>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/projects'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Project CreateProject(CreateOrUpdateProject model, string expand = null)
        {
            var operation = Operations.CreateProject(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Project>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/projects'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Project> CreateProjectAsync(CreateOrUpdateProject model, string expand = null)
        {
            var operation = Operations.CreateProject(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Project>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/projectssearch'
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<Project> SearchProjectsByPartialName(string query = null, bool? valuesqry = null, string expand = null)
        {
            var operation = Operations.SearchProjectsByPartialName(query, valuesqry, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Project>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/projectssearch'  (asynchronous)
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Project>> SearchProjectsByPartialNameAsync(string query = null, bool? valuesqry = null, string expand = null)
        {
            var operation = Operations.SearchProjectsByPartialName(query, valuesqry, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Project>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/projectssearch'
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage SearchProjectsByPartialNameUsingPostMethod(string valuesqry = null, string query = null, string expand = null)
        {
            var operation = Operations.SearchProjectsByPartialNameUsingPostMethod(valuesqry, query, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/projectssearch'  (asynchronous)
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SearchProjectsByPartialNameUsingPostMethodAsync(string valuesqry = null, string query = null, string expand = null)
        {
            var operation = Operations.SearchProjectsByPartialNameUsingPostMethod(valuesqry, query, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/projecttemplates'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ProjectTemplate> SearchProjectTemplates(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchProjectTemplates(top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ProjectTemplate>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/projecttemplates'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ProjectTemplate>> SearchProjectTemplatesAsync(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchProjectTemplates(top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ProjectTemplate>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/relationshiptypes'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<RelationshipType> GetAllRelationshipTypes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAllRelationshipTypes(top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<RelationshipType>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/relationshiptypes'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<RelationshipType>> GetAllRelationshipTypesAsync(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetAllRelationshipTypes(top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<RelationshipType>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Requirement GetRequirement(string id, string expand = null)
        {
            var operation = Operations.GetRequirement(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Requirement>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirement/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Requirement> GetRequirementAsync(string id, string expand = null)
        {
            var operation = Operations.GetRequirement(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Requirement>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/requirement/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Requirement UpdateExistingRequirement(string id, CreateOrUpdateRequirement model, string expand = null)
        {
            var operation = Operations.UpdateExistingRequirement(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Requirement>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/requirement/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Requirement> UpdateExistingRequirementAsync(string id, CreateOrUpdateRequirement model, string expand = null)
        {
            var operation = Operations.UpdateExistingRequirement(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Requirement>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/requirement/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteRequirement(string id)
        {
            var operation = Operations.DeleteRequirement(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/requirement/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteRequirementAsync(string id)
        {
            var operation = Operations.DeleteRequirement(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetRequirementAllRelationships(string id)
        {
            var operation = Operations.GetRequirementAllRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirement/{id}/allrelationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetRequirementAllRelationshipsAsync(string id)
        {
            var operation = Operations.GetRequirementAllRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<RequirementAttachment> GetRequirementAttachments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRequirementAttachments(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<RequirementAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirement/{id}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<RequirementAttachment>> GetRequirementAttachmentsAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRequirementAttachments(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<RequirementAttachment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/requirement/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<RequirementAttachment> CreateRequirementAttachment(string id)
        {
            var operation = Operations.CreateRequirementAttachment(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<RequirementAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/requirement/{id}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<RequirementAttachment>> CreateRequirementAttachmentAsync(string id)
        {
            var operation = Operations.CreateRequirementAttachment(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<RequirementAttachment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}/children'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<Requirement> GetRequirementsChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRequirementsChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Requirement>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirement/{id}/children'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Requirement>> GetRequirementsChildrenAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRequirementsChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Requirement>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}/comments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ExternalSystemComment> GetExternalTicketComments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetExternalTicketComments(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ExternalSystemComment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirement/{id}/comments'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ExternalSystemComment>> GetExternalTicketCommentsAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetExternalTicketComments(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ExternalSystemComment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetRequirementRelationships(string id)
        {
            var operation = Operations.GetRequirementRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirement/{id}/relationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetRequirementRelationshipsAsync(string id)
        {
            var operation = Operations.GetRequirementRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a DELETE to '/api/requirement/{requirementId}/attachment/{id}'
        /// </summary>
        /// <param name="requirementId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteRequirementAttachment(string requirementId, string id)
        {
            var operation = Operations.DeleteRequirementAttachment(requirementId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/requirement/{requirementId}/attachment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="requirementId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteRequirementAttachmentAsync(string requirementId, string id)
        {
            var operation = Operations.DeleteRequirementAttachment(requirementId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirementpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual RequirementPackage GetRequirementPackage(string id, string expand = null)
        {
            var operation = Operations.GetRequirementPackage(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<RequirementPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirementpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<RequirementPackage> GetRequirementPackageAsync(string id, string expand = null)
        {
            var operation = Operations.GetRequirementPackage(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<RequirementPackage>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/requirementpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual RequirementPackage UpdateRequirementPackage(string id, CreateOrUpdateRequirementPackage model, string expand = null)
        {
            var operation = Operations.UpdateRequirementPackage(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<RequirementPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/requirementpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<RequirementPackage> UpdateRequirementPackageAsync(string id, CreateOrUpdateRequirementPackage model, string expand = null)
        {
            var operation = Operations.UpdateRequirementPackage(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<RequirementPackage>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/requirementpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteRequirementPackage(string id)
        {
            var operation = Operations.DeleteRequirementPackage(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/requirementpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteRequirementPackageAsync(string id)
        {
            var operation = Operations.DeleteRequirementPackage(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirementpackage/{id}/children'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<RequirementPackage> GetRequirementPackageChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRequirementPackageChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<RequirementPackage>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirementpackage/{id}/children'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<RequirementPackage>> GetRequirementPackageChildrenAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetRequirementPackageChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<RequirementPackage>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirementpackages'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<RequirementPackage> GetRequirementPackages(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.GetRequirementPackages(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<RequirementPackage>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirementpackages'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<RequirementPackage>> GetRequirementPackagesAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.GetRequirementPackages(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<RequirementPackage>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/requirementpackages'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual RequirementPackage CreateRequirementPackage(CreateOrUpdateRequirementPackage model, string expand = null)
        {
            var operation = Operations.CreateRequirementPackage(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<RequirementPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/requirementpackages'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<RequirementPackage> CreateRequirementPackageAsync(CreateOrUpdateRequirementPackage model, string expand = null)
        {
            var operation = Operations.CreateRequirementPackage(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<RequirementPackage>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/requirements'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<Requirement> SearchRequirements(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchRequirements(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Requirement>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/requirements'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Requirement>> SearchRequirementsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchRequirements(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Requirement>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/requirements'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Requirement CreateRequirement(CreateOrUpdateRequirement model, string expand = null)
        {
            var operation = Operations.CreateRequirement(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Requirement>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/requirements'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Requirement> CreateRequirementAsync(CreateOrUpdateRequirement model, string expand = null)
        {
            var operation = Operations.CreateRequirement(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Requirement>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/script/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Script GetScript(string id, string expand = null)
        {
            var operation = Operations.GetScript(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Script>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/script/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Script> GetScriptAsync(string id, string expand = null)
        {
            var operation = Operations.GetScript(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Script>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/script/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Script UpdateScript(string id, CreateOrUpdateScript model, string expand = null)
        {
            var operation = Operations.UpdateScript(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Script>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/script/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Script> UpdateScriptAsync(string id, CreateOrUpdateScript model, string expand = null)
        {
            var operation = Operations.UpdateScript(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Script>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/script/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteScript(string id)
        {
            var operation = Operations.DeleteScript(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/script/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteScriptAsync(string id)
        {
            var operation = Operations.DeleteScript(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/script/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetScriptAllRelationships(string id)
        {
            var operation = Operations.GetScriptAllRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/script/{id}/allrelationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetScriptAllRelationshipsAsync(string id)
        {
            var operation = Operations.GetScriptAllRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/script/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ScriptAttachment> GetScriptAttachments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetScriptAttachments(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ScriptAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/script/{id}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ScriptAttachment>> GetScriptAttachmentsAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetScriptAttachments(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ScriptAttachment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/script/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<ScriptAttachment> CreateScriptAttachment(string id)
        {
            var operation = Operations.CreateScriptAttachment(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<ScriptAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/script/{id}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<ScriptAttachment>> CreateScriptAttachmentAsync(string id)
        {
            var operation = Operations.CreateScriptAttachment(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<ScriptAttachment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/script/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetScriptRelationships(string id)
        {
            var operation = Operations.GetScriptRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/script/{id}/relationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetScriptRelationshipsAsync(string id)
        {
            var operation = Operations.GetScriptRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/script/{scriptId}/assignments'
        /// </summary>
        /// <param name="scriptId">a path parameter (no description)</param>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<ScriptAssignment> GetAssignmentsForScript(string scriptId, string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.GetAssignmentsForScript(scriptId, tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ScriptAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/script/{scriptId}/assignments'  (asynchronous)
        /// </summary>
        /// <param name="scriptId">a path parameter (no description)</param>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ScriptAssignment>> GetAssignmentsForScriptAsync(string scriptId, string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.GetAssignmentsForScript(scriptId, tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ScriptAssignment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/script/{scriptId}/assignments'
        /// </summary>
        /// <param name="scriptId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptAssignment CreateAssignmentForScript(string scriptId, CreateOrUpdateScriptAssignment model, string expand = null)
        {
            var operation = Operations.CreateAssignmentForScript(scriptId, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptAssignment>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/script/{scriptId}/assignments'  (asynchronous)
        /// </summary>
        /// <param name="scriptId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptAssignment> CreateAssignmentForScriptAsync(string scriptId, CreateOrUpdateScriptAssignment model, string expand = null)
        {
            var operation = Operations.CreateAssignmentForScript(scriptId, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptAssignment>();
			return result;
						
		}


        /// <summary>
        /// Sends a DELETE to '/api/script/{scriptId}/attachment/{id}'
        /// </summary>
        /// <param name="scriptId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteScriptAttachment(string scriptId, string id)
        {
            var operation = Operations.DeleteScriptAttachment(scriptId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/script/{scriptId}/attachment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="scriptId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteScriptAttachmentAsync(string scriptId, string id)
        {
            var operation = Operations.DeleteScriptAttachment(scriptId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptAssignment GetScriptAssignment(string id, string expand = null)
        {
            var operation = Operations.GetScriptAssignment(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptAssignment>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptAssignment> GetScriptAssignmentAsync(string id, string expand = null)
        {
            var operation = Operations.GetScriptAssignment(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptAssignment>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/scriptassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptAssignment UpdateScriptAssignment(string id, CreateOrUpdateScriptAssignment model, string expand = null)
        {
            var operation = Operations.UpdateScriptAssignment(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptAssignment>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/scriptassignment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptAssignment> UpdateScriptAssignmentAsync(string id, CreateOrUpdateScriptAssignment model, string expand = null)
        {
            var operation = Operations.UpdateScriptAssignment(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptAssignment>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/scriptassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteScriptAssignment(string id)
        {
            var operation = Operations.DeleteScriptAssignment(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/scriptassignment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteScriptAssignmentAsync(string id)
        {
            var operation = Operations.DeleteScriptAssignment(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetScriptAssignmentAllRelationships(string id)
        {
            var operation = Operations.GetScriptAssignmentAllRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}/allrelationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetScriptAssignmentAllRelationshipsAsync(string id)
        {
            var operation = Operations.GetScriptAssignmentAllRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual Relationship GetScriptAssignmentRelationships(string id)
        {
            var operation = Operations.GetScriptAssignmentRelationships(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Relationship>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}/relationships'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<Relationship> GetScriptAssignmentRelationshipsAsync(string id)
        {
            var operation = Operations.GetScriptAssignmentRelationships(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Relationship>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}/runs'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ScriptRun> SearchScriptRunsForScriptAssignment(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchScriptRunsForScriptAssignment(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ScriptRun>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}/runs'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ScriptRun>> SearchScriptRunsForScriptAssignmentAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchScriptRunsForScriptAssignment(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ScriptRun>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/scriptassignment/{id}/runs'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptRun CreateScriptRunForScriptAssignment(string id, CreateNewRun model, string expand = null)
        {
            var operation = Operations.CreateScriptRunForScriptAssignment(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptRun>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/scriptassignment/{id}/runs'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptRun> CreateScriptRunForScriptAssignmentAsync(string id, CreateNewRun model, string expand = null)
        {
            var operation = Operations.CreateScriptRunForScriptAssignment(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptRun>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptassignments'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<ScriptAssignment> SearchScriptAssignments(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchScriptAssignments(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ScriptAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptassignments'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ScriptAssignment>> SearchScriptAssignmentsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchScriptAssignments(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ScriptAssignment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/scriptassignments'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptAssignment CreateScriptAssignment(CreateOrUpdateScriptAssignment model, string expand = null)
        {
            var operation = Operations.CreateScriptAssignment(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptAssignment>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/scriptassignments'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptAssignment> CreateScriptAssignmentAsync(CreateOrUpdateScriptAssignment model, string expand = null)
        {
            var operation = Operations.CreateScriptAssignment(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptAssignment>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptPackage GetScriptPackage(string id, string expand = null)
        {
            var operation = Operations.GetScriptPackage(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptPackage> GetScriptPackageAsync(string id, string expand = null)
        {
            var operation = Operations.GetScriptPackage(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptPackage>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/scriptpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptPackage UpdateScriptPackage(string id, CreateOrUpdateScriptPackage model, string expand = null)
        {
            var operation = Operations.UpdateScriptPackage(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/scriptpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptPackage> UpdateScriptPackageAsync(string id, CreateOrUpdateScriptPackage model, string expand = null)
        {
            var operation = Operations.UpdateScriptPackage(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptPackage>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/scriptpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteScriptPackage(string id)
        {
            var operation = Operations.DeleteScriptPackage(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/scriptpackage/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteScriptPackageAsync(string id)
        {
            var operation = Operations.DeleteScriptPackage(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptpackage/{id}/children'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<ScriptPackage> GetScriptPackagesChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetScriptPackagesChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ScriptPackage>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptpackage/{id}/children'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ScriptPackage>> GetScriptPackagesChildrenAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetScriptPackagesChildren(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ScriptPackage>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptpackages'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<ScriptPackage> SearchScriptPackages(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchScriptPackages(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ScriptPackage>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptpackages'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ScriptPackage>> SearchScriptPackagesAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchScriptPackages(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ScriptPackage>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/scriptpackages'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptPackage CreateScriptPackage(CreateOrUpdateScriptPackage model, string expand = null)
        {
            var operation = Operations.CreateScriptPackage(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptPackage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/scriptpackages'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptPackage> CreateScriptPackageAsync(CreateOrUpdateScriptPackage model, string expand = null)
        {
            var operation = Operations.CreateScriptPackage(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptPackage>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptRun GetScriptRun(string id, string expand = null)
        {
            var operation = Operations.GetScriptRun(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptRun>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptrun/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptRun> GetScriptRunAsync(string id, string expand = null)
        {
            var operation = Operations.GetScriptRun(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptRun>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/scriptrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual ScriptRun UpdateScriptRun(string id, UpdateScriptRun model, string expand = null)
        {
            var operation = Operations.UpdateScriptRun(id, model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<ScriptRun>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/scriptrun/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<ScriptRun> UpdateScriptRunAsync(string id, UpdateScriptRun model, string expand = null)
        {
            var operation = Operations.UpdateScriptRun(id, model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<ScriptRun>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/scriptrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteScriptRun(string id)
        {
            var operation = Operations.DeleteScriptRun(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/scriptrun/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteScriptRunAsync(string id)
        {
            var operation = Operations.DeleteScriptRun(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/scriptruns'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<ScriptRun> SearchScriptRuns(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchScriptRuns(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<ScriptRun>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scriptruns'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<ScriptRun>> SearchScriptRunsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchScriptRuns(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<ScriptRun>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/scripts'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<Script> SearchScripts(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchScripts(tql, timeZone, top, skip, inlinecount, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Script>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/scripts'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Script>> SearchScriptsAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            var operation = Operations.SearchScripts(tql, timeZone, top, skip, inlinecount, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Script>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/scripts'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual Script CreateScript(CreateOrUpdateScript model, string expand = null)
        {
            var operation = Operations.CreateScript(model, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<Script>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/scripts'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<Script> CreateScriptAsync(CreateOrUpdateScript model, string expand = null)
        {
            var operation = Operations.CreateScript(model, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<Script>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/search'
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="indexName">a query parameter (no description)</param>
        /// <param name="format">a query parameter (no description)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage Search(string tql = null, string indexName = null, string format = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null)
        {
            var operation = Operations.Search(tql, indexName, format, timeZone, top, skip, inlinecount);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a GET to '/api/search'  (asynchronous)
        /// </summary>
        /// <param name="tql">a query parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="indexName">a query parameter (no description)</param>
        /// <param name="format">a query parameter (no description)</param>
        /// <param name="timeZone">a query parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SearchAsync(string tql = null, string indexName = null, string format = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null)
        {
            var operation = Operations.Search(tql, indexName, format, timeZone, top, skip, inlinecount);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}

        /// <summary>
        /// Sends a POST to '/api/search'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="tql">a form parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a form parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage SearchUsingPostMethod(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null)
        {
            var operation = Operations.SearchUsingPostMethod(tql, timeZone, top, skip, inlinecount);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/search'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="tql">a form parameter (TQL query to execute, including an optional ORDER BY statement to sort the results (see TQL API feature topic in Knowledgebase for more details).)</param>
        /// <param name="timeZone">a form parameter (Time Zone in which date and time values and calculates should be evaluated (see TimeZone API feature topic in Knowledgebase for more details).)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SearchUsingPostMethodAsync(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null)
        {
            var operation = Operations.SearchUsingPostMethod(tql, timeZone, top, skip, inlinecount);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/search/index/{indexName}'
        /// </summary>
        /// <param name="indexName">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual IndexMetadata GetSearchIndex(string indexName)
        {
            var operation = Operations.GetSearchIndex(indexName);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<IndexMetadata>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/search/index/{indexName}'  (asynchronous)
        /// </summary>
        /// <param name="indexName">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<IndexMetadata> GetSearchIndexAsync(string indexName)
        {
            var operation = Operations.GetSearchIndex(indexName);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<IndexMetadata>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/search/indexes'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<IndexMetadata> GetSearchIndexes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetSearchIndexes(top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<IndexMetadata>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/search/indexes'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<IndexMetadata>> GetSearchIndexesAsync(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetSearchIndexes(top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<IndexMetadata>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/stepresult/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual StepResult GetStepResult(string id, string expand = null)
        {
            var operation = Operations.GetStepResult(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<StepResult>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/stepresult/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<StepResult> GetStepResultAsync(string id, string expand = null)
        {
            var operation = Operations.GetStepResult(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<StepResult>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/stepresult/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<StepResultAttachment> GetStepResultAttachments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetStepResultAttachments(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<StepResultAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/stepresult/{id}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<StepResultAttachment>> GetStepResultAttachmentsAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetStepResultAttachments(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<StepResultAttachment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/stepresult/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<StepResultAttachment> CreateStepResultAttachment(string id)
        {
            var operation = Operations.CreateStepResultAttachment(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<StepResultAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/stepresult/{id}/attachments'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<StepResultAttachment>> CreateStepResultAttachmentAsync(string id)
        {
            var operation = Operations.CreateStepResultAttachment(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<StepResultAttachment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/stepresult/{id}/incidents'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<StepRunResultIncident> GetStepResultIncidentLinks(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetStepResultIncidentLinks(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<StepRunResultIncident>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/stepresult/{id}/incidents'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<StepRunResultIncident>> GetStepResultIncidentLinksAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetStepResultIncidentLinks(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<StepRunResultIncident>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/stepresult/{id}/incidents'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual StepRunResultIncident CreateStepResultIncidentLink(string id, CreateStepRunResultIncident model)
        {
            var operation = Operations.CreateStepResultIncidentLink(id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<StepRunResultIncident>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/stepresult/{id}/incidents'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<StepRunResultIncident> CreateStepResultIncidentLinkAsync(string id, CreateStepRunResultIncident model)
        {
            var operation = Operations.CreateStepResultIncidentLink(id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<StepRunResultIncident>();
			return result;
						
		}


        /// <summary>
        /// Sends a DELETE to '/api/stepresult/{stepResultId}/attachment/{id}'
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteStepResultAttachment(string stepResultId, string id)
        {
            var operation = Operations.DeleteStepResultAttachment(stepResultId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/stepresult/{stepResultId}/attachment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteStepResultAttachmentAsync(string stepResultId, string id)
        {
            var operation = Operations.DeleteStepResultAttachment(stepResultId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/stepresult/{stepResultId}/incident/{id}'
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual StepRunResultIncident GetStepResultIncidentLink(string stepResultId, string id)
        {
            var operation = Operations.GetStepResultIncidentLink(stepResultId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<StepRunResultIncident>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/stepresult/{stepResultId}/incident/{id}'  (asynchronous)
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<StepRunResultIncident> GetStepResultIncidentLinkAsync(string stepResultId, string id)
        {
            var operation = Operations.GetStepResultIncidentLink(stepResultId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<StepRunResultIncident>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/stepresult/{stepResultId}/incident/{id}'
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteStepResultIncidentLink(string stepResultId, string id)
        {
            var operation = Operations.DeleteStepResultIncidentLink(stepResultId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/stepresult/{stepResultId}/incident/{id}'  (asynchronous)
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteStepResultIncidentLinkAsync(string stepResultId, string id)
        {
            var operation = Operations.DeleteStepResultIncidentLink(stepResultId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/swagger'
        /// </summary>
        /// <returns></returns>
        public virtual SwaggerResourceListing GetSwaggerAPIList()
        {
            var operation = Operations.GetSwaggerAPIList();
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<SwaggerResourceListing>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/swagger'  (asynchronous)
        /// </summary>
        /// <returns></returns>
        public virtual async Task<SwaggerResourceListing> GetSwaggerAPIListAsync()
        {
            var operation = Operations.GetSwaggerAPIList();
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<SwaggerResourceListing>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/swagger/api'
        /// </summary>
        /// <returns></returns>
        public virtual HttpResponseMessage GetSwaggerForCoreAPI()
        {
            var operation = Operations.GetSwaggerForCoreAPI();
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a GET to '/api/swagger/api'  (asynchronous)
        /// </summary>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> GetSwaggerForCoreAPIAsync()
        {
            var operation = Operations.GetSwaggerForCoreAPI();
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/synchronizer/{id}/schedules'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<SynchronizationScheduleInfo> GetSynchronizerSchedules(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetSynchronizerSchedules(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<SynchronizationScheduleInfo>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/synchronizer/{id}/schedules'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<SynchronizationScheduleInfo>> GetSynchronizerSchedulesAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetSynchronizerSchedules(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<SynchronizationScheduleInfo>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/synchronizer/{id}/schedules'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual SynchronizationScheduleInfo CreateSynchronizerSchedule(string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            var operation = Operations.CreateSynchronizerSchedule(id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<SynchronizationScheduleInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/synchronizer/{id}/schedules'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<SynchronizationScheduleInfo> CreateSynchronizerScheduleAsync(string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            var operation = Operations.CreateSynchronizerSchedule(id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<SynchronizationScheduleInfo>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/synchronizer/{linkId}/schedule/{id}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual SynchronizationScheduleInfo GetLinkSynchronizationSchedule(string linkId, string id)
        {
            var operation = Operations.GetLinkSynchronizationSchedule(linkId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<SynchronizationScheduleInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/synchronizer/{linkId}/schedule/{id}'  (asynchronous)
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<SynchronizationScheduleInfo> GetLinkSynchronizationScheduleAsync(string linkId, string id)
        {
            var operation = Operations.GetLinkSynchronizationSchedule(linkId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<SynchronizationScheduleInfo>();
			return result;
						
		}

        /// <summary>
        /// Sends a PATCH to '/api/synchronizer/{linkId}/schedule/{id}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual SynchronizationScheduleInfo PatchLinkSynchronizationSchedule(string linkId, string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            var operation = Operations.PatchLinkSynchronizationSchedule(linkId, id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<SynchronizationScheduleInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PATCH to '/api/synchronizer/{linkId}/schedule/{id}'  (asynchronous)
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<SynchronizationScheduleInfo> PatchLinkSynchronizationScheduleAsync(string linkId, string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            var operation = Operations.PatchLinkSynchronizationSchedule(linkId, id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<SynchronizationScheduleInfo>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/synchronizer/{linkId}/schedule/{id}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual SynchronizationScheduleInfo UpdateLinkSynchronizationSchedule(string linkId, string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            var operation = Operations.UpdateLinkSynchronizationSchedule(linkId, id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<SynchronizationScheduleInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/synchronizer/{linkId}/schedule/{id}'  (asynchronous)
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<SynchronizationScheduleInfo> UpdateLinkSynchronizationScheduleAsync(string linkId, string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            var operation = Operations.UpdateLinkSynchronizationSchedule(linkId, id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<SynchronizationScheduleInfo>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/synchronizer/{linkId}/schedule/{id}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteLinkSynchronizationSchedule(string linkId, string id)
        {
            var operation = Operations.DeleteLinkSynchronizationSchedule(linkId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/synchronizer/{linkId}/schedule/{id}'  (asynchronous)
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteLinkSynchronizationScheduleAsync(string linkId, string id)
        {
            var operation = Operations.DeleteLinkSynchronizationSchedule(linkId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a POST to '/api/synchronizer/{linkId}/schedule/{id}/run'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage StartScheduleSynchronizing(string linkId, string id)
        {
            var operation = Operations.StartScheduleSynchronizing(linkId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/synchronizer/{linkId}/schedule/{id}/run'  (asynchronous)
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> StartScheduleSynchronizingAsync(string linkId, string id)
        {
            var operation = Operations.StartScheduleSynchronizing(linkId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/systemevent/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual SystemEvent GetSystemEvent(string id)
        {
            var operation = Operations.GetSystemEvent(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<SystemEvent>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/systemevent/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<SystemEvent> GetSystemEventAsync(string id)
        {
            var operation = Operations.GetSystemEvent(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<SystemEvent>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/systemevent/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteSystemEvent(string id)
        {
            var operation = Operations.DeleteSystemEvent(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/systemevent/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteSystemEventAsync(string id)
        {
            var operation = Operations.DeleteSystemEvent(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/systemevents'
        /// </summary>
        /// <param name="fileName">a query parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<SystemEvent> GetSystemEvents(string fileName = null, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetSystemEvents(fileName, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<SystemEvent>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/systemevents'  (asynchronous)
        /// </summary>
        /// <param name="fileName">a query parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<SystemEvent>> GetSystemEventsAsync(string fileName = null, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetSystemEvents(fileName, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<SystemEvent>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/systemevents'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual SystemEvent AddSystemEvent(CreateOrUpdateSystemEvent model)
        {
            var operation = Operations.AddSystemEvent(model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<SystemEvent>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/systemevents'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<SystemEvent> AddSystemEventAsync(CreateOrUpdateSystemEvent model)
        {
            var operation = Operations.AddSystemEvent(model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<SystemEvent>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/systemevents'
        /// </summary>
        /// <param name="linkId">a query parameter (no description)</param>
        /// <param name="documentId">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteSystemEventsForLink(string linkId = null, string documentId = null)
        {
            var operation = Operations.DeleteSystemEventsForLink(linkId, documentId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/systemevents'  (asynchronous)
        /// </summary>
        /// <param name="linkId">a query parameter (no description)</param>
        /// <param name="documentId">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteSystemEventsForLinkAsync(string linkId = null, string documentId = null)
        {
            var operation = Operations.DeleteSystemEventsForLink(linkId, documentId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/systeminfo'
        /// </summary>
        /// <returns></returns>
        public virtual SystemInfo GetSystemInformation()
        {
            var operation = Operations.GetSystemInformation();
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<SystemInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/systeminfo'  (asynchronous)
        /// </summary>
        /// <returns></returns>
        public virtual async Task<SystemInfo> GetSystemInformationAsync()
        {
            var operation = Operations.GetSystemInformation();
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<SystemInfo>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/temporaryattachmentset/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<TemporaryAttachment> GetTemporaryAttachmentsForSet(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetTemporaryAttachmentsForSet(id, top, skip, inlinecount, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<TemporaryAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/temporaryattachmentset/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<TemporaryAttachment>> GetTemporaryAttachmentsForSetAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetTemporaryAttachmentsForSet(id, top, skip, inlinecount, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<TemporaryAttachment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/temporaryattachmentset/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<TemporaryAttachment> UploadAttachments(string id)
        {
            var operation = Operations.UploadAttachments(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<TemporaryAttachment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/temporaryattachmentset/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<TemporaryAttachment>> UploadAttachmentsAsync(string id)
        {
            var operation = Operations.UploadAttachments(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<TemporaryAttachment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a DELETE to '/api/temporaryattachmentset/{setId}/attachment/{id}'
        /// </summary>
        /// <param name="setId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteTemporaryAttachmentFromSet(string setId, string id)
        {
            var operation = Operations.DeleteTemporaryAttachmentFromSet(setId, id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/temporaryattachmentset/{setId}/attachment/{id}'  (asynchronous)
        /// </summary>
        /// <param name="setId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteTemporaryAttachmentFromSetAsync(string setId, string id)
        {
            var operation = Operations.DeleteTemporaryAttachmentFromSet(setId, id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a POST to '/api/temporaryattachmentsets'
        /// </summary>
        /// <returns></returns>
        public virtual TemporaryAttachmentSets CreateTemporaryAttachmentSet()
        {
            var operation = Operations.CreateTemporaryAttachmentSet();
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<TemporaryAttachmentSets>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/temporaryattachmentsets'  (asynchronous)
        /// </summary>
        /// <returns></returns>
        public virtual async Task<TemporaryAttachmentSets> CreateTemporaryAttachmentSetAsync()
        {
            var operation = Operations.CreateTemporaryAttachmentSet();
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<TemporaryAttachmentSets>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/timezone'
        /// </summary>
        /// <param name="id">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual TimeZoneInfo GetTimezoneInformation(string id = null)
        {
            var operation = Operations.GetTimezoneInformation(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<TimeZoneInfo>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/timezone'  (asynchronous)
        /// </summary>
        /// <param name="id">a query parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<TimeZoneInfo> GetTimezoneInformationAsync(string id = null)
        {
            var operation = Operations.GetTimezoneInformation(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<TimeZoneInfo>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/user/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual User GetUser(string id, string expand = null)
        {
            var operation = Operations.GetUser(id, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<User>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/user/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<User> GetUserAsync(string id, string expand = null)
        {
            var operation = Operations.GetUser(id, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<User>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/user/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual User UpdateUser(string id, CreateOrUpdateUser model)
        {
            var operation = Operations.UpdateUser(id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<User>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/user/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<User> UpdateUserAsync(string id, CreateOrUpdateUser model)
        {
            var operation = Operations.UpdateUser(id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<User>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/user/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteUser(string id)
        {
            var operation = Operations.DeleteUser(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/user/{id}'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteUserAsync(string id)
        {
            var operation = Operations.DeleteUser(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/user/{id}/groups'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<Group> GetUsersGroups(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetUsersGroups(id, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Group>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/user/{id}/groups'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Group>> GetUsersGroupsAsync(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.GetUsersGroups(id, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Group>>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/user/{id}/groups'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<Group> SetGroupMembershipsForUser(string id, GroupMemberships model, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SetGroupMembershipsForUser(id, model, top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<Group>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/user/{id}/groups'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<Group>> SetGroupMembershipsForUserAsync(string id, GroupMemberships model, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SetGroupMembershipsForUser(id, model, top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<Group>>();
			return result;
						
		}


        /// <summary>
        /// Sends a PUT to '/api/user/{id}/password'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage SetUserPassword(string id, SetPassword model)
        {
            var operation = Operations.SetUserPassword(id, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a PUT to '/api/user/{id}/password'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SetUserPasswordAsync(string id, SetPassword model)
        {
            var operation = Operations.SetUserPassword(id, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


        /// <summary>
        /// Sends a GET to '/api/user/{id}/permissions/global'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<PermissionAssignment> GetGlobalUserPermissions(string id)
        {
            var operation = Operations.GetGlobalUserPermissions(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<PermissionAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/user/{id}/permissions/global'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<PermissionAssignment>> GetGlobalUserPermissionsAsync(string id)
        {
            var operation = Operations.GetGlobalUserPermissions(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<PermissionAssignment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/user/{id}/permissions/global'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual List<PermissionAssignment> SetGlobalPermissionsForUser(string id, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            var operation = Operations.SetGlobalPermissionsForUser(id, assignments);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<PermissionAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/user/{id}/permissions/global'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<PermissionAssignment>> SetGlobalPermissionsForUserAsync(string id, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            var operation = Operations.SetGlobalPermissionsForUser(id, assignments);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<PermissionAssignment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/user/{id}/permissions/projects'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual UserPermissionProjects GetProjectUserPermissionLinks(string id)
        {
            var operation = Operations.GetProjectUserPermissionLinks(id);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<UserPermissionProjects>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/user/{id}/permissions/projects'  (asynchronous)
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<UserPermissionProjects> GetProjectUserPermissionLinksAsync(string id)
        {
            var operation = Operations.GetProjectUserPermissionLinks(id);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<UserPermissionProjects>();
			return result;
						
		}


        /// <summary>
        /// Sends a POST to '/api/user/{userId}/mailmessages'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual QueuedMessage EnqueueMailMessage(string userId, Message model)
        {
            var operation = Operations.EnqueueMailMessage(userId, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueuedMessage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/user/{userId}/mailmessages'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<QueuedMessage> EnqueueMailMessageAsync(string userId, Message model)
        {
            var operation = Operations.EnqueueMailMessage(userId, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueuedMessage>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/user/{userId}/notification/{notificationId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual NotificationMessage GetNotificationMessage(string userId, string notificationId)
        {
            var operation = Operations.GetNotificationMessage(userId, notificationId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<NotificationMessage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/user/{userId}/notification/{notificationId}'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<NotificationMessage> GetNotificationMessageAsync(string userId, string notificationId)
        {
            var operation = Operations.GetNotificationMessage(userId, notificationId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<NotificationMessage>();
			return result;
						
		}

        /// <summary>
        /// Sends a PATCH to '/api/user/{userId}/notification/{notificationId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual NotificationMessage PatchNotificationMessage(string userId, string notificationId, UpdateNotification model)
        {
            var operation = Operations.PatchNotificationMessage(userId, notificationId, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<NotificationMessage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PATCH to '/api/user/{userId}/notification/{notificationId}'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<NotificationMessage> PatchNotificationMessageAsync(string userId, string notificationId, UpdateNotification model)
        {
            var operation = Operations.PatchNotificationMessage(userId, notificationId, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<NotificationMessage>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/user/{userId}/notification/{notificationId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void DeleteNotificationMessage(string userId, string notificationId)
        {
            var operation = Operations.DeleteNotificationMessage(userId, notificationId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/user/{userId}/notification/{notificationId}'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task DeleteNotificationMessageAsync(string userId, string notificationId)
        {
            var operation = Operations.DeleteNotificationMessage(userId, notificationId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/user/{userId}/notifications'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual QueryResults<NotificationMessage> GetNotificationsMessagesForUser(string userId)
        {
            var operation = Operations.GetNotificationsMessagesForUser(userId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<NotificationMessage>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/user/{userId}/notifications'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<NotificationMessage>> GetNotificationsMessagesForUserAsync(string userId)
        {
            var operation = Operations.GetNotificationsMessagesForUser(userId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<NotificationMessage>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/user/{userId}/notifications'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual NotificationMessage CreateNotificationMessage(string userId, CreateNotification model)
        {
            var operation = Operations.CreateNotificationMessage(userId, model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<NotificationMessage>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/user/{userId}/notifications'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<NotificationMessage> CreateNotificationMessageAsync(string userId, CreateNotification model)
        {
            var operation = Operations.CreateNotificationMessage(userId, model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<NotificationMessage>();
			return result;
						
		}

        /// <summary>
        /// Sends a DELETE to '/api/user/{userId}/notifications'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual void ClearNotificationMessagesForUser(string userId)
        {
            var operation = Operations.ClearNotificationMessagesForUser(userId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			
		}

		/// <summary>
        /// Sends a DELETE to '/api/user/{userId}/notifications'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task ClearNotificationMessagesForUserAsync(string userId)
        {
            var operation = Operations.ClearNotificationMessagesForUser(userId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
						
		}


        /// <summary>
        /// Sends a GET to '/api/user/{userId}/permissions/project/{projectId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual List<PermissionAssignment> GetUserProjectPermissions(string userId, string projectId)
        {
            var operation = Operations.GetUserProjectPermissions(userId, projectId);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<PermissionAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/user/{userId}/permissions/project/{projectId}'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<PermissionAssignment>> GetUserProjectPermissionsAsync(string userId, string projectId)
        {
            var operation = Operations.GetUserProjectPermissions(userId, projectId);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<PermissionAssignment>>();
			return result;
						
		}

        /// <summary>
        /// Sends a PUT to '/api/user/{userId}/permissions/project/{projectId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual List<PermissionAssignment> SetUserProjectPermissions(string userId, string projectId, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            var operation = Operations.SetUserProjectPermissions(userId, projectId, assignments);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<List<PermissionAssignment>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a PUT to '/api/user/{userId}/permissions/project/{projectId}'  (asynchronous)
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<List<PermissionAssignment>> SetUserProjectPermissionsAsync(string userId, string projectId, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            var operation = Operations.SetUserProjectPermissions(userId, projectId, assignments);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<List<PermissionAssignment>>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/users'
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual QueryResults<User> SearchUsers(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchUsers(top, skip, inlinecount, expand, filter, orderby);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<User>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/users'  (asynchronous)
        /// </summary>
        /// <param name="top">a query parameter (Sets the maximum number of results to return)</param>
        /// <param name="skip">a query parameter (Sets the number of results to skip, before return up the $top number of matching items.)</param>
        /// <param name="inlinecount">a query parameter (Determines if the count and total number of results should be included as part of the result set)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="filter">a query parameter (OData filter identifying a subset of results to return.)</param>
        /// <param name="orderby">a query parameter (OData order-by syntax to order results by one or more fields in ascending or descending order.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<User>> SearchUsersAsync(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            var operation = Operations.SearchUsers(top, skip, inlinecount, expand, filter, orderby);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<User>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/users'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual User CreateUser(CreateOrUpdateUser model)
        {
            var operation = Operations.CreateUser(model);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<User>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a POST to '/api/users'  (asynchronous)
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public virtual async Task<User> CreateUserAsync(CreateOrUpdateUser model)
        {
            var operation = Operations.CreateUser(model);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<User>();
			return result;
						
		}


        /// <summary>
        /// Sends a GET to '/api/userssearch'
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual QueryResults<User> SearchUsersByPartialName(string query = null, bool? valuesqry = null, string expand = null)
        {
            var operation = Operations.SearchUsersByPartialName(query, valuesqry, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			var result = response.Content.ReadAsAsync<QueryResults<User>>().Result;
			return result;
			
		}

		/// <summary>
        /// Sends a GET to '/api/userssearch'  (asynchronous)
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public virtual async Task<QueryResults<User>> SearchUsersByPartialNameAsync(string query = null, bool? valuesqry = null, string expand = null)
        {
            var operation = Operations.SearchUsersByPartialName(query, valuesqry, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			var result = await response.Content.ReadAsAsync<QueryResults<User>>();
			return result;
						
		}

        /// <summary>
        /// Sends a POST to '/api/userssearch'
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual HttpResponseMessage SearchUsersByPartialNameUsingPostMethod(string valuesqry = null, string query = null, string expand = null)
        {
            var operation = Operations.SearchUsersByPartialNameUsingPostMethod(valuesqry, query, expand);
			var response = _client.SendAsync(operation.BuildRequest(_client)).Result;
			EnsureSuccess(response);
			return response;
		}

		/// <summary>
        /// Sends a POST to '/api/userssearch'  (asynchronous)
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public virtual async Task<HttpResponseMessage> SearchUsersByPartialNameUsingPostMethodAsync(string valuesqry = null, string query = null, string expand = null)
        {
            var operation = Operations.SearchUsersByPartialNameUsingPostMethod(valuesqry, query, expand);
			var response = await _client.SendAsync(operation.BuildRequest(_client));
			EnsureSuccess(response);
			return response;
						
		}


    }
}


