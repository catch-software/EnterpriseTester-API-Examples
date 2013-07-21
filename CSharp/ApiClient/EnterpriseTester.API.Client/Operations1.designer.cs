using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using EnterpriseTester.API.Client.Models;

namespace EnterpriseTester.API.Client
{
    public static class Operations
    {


        /// <summary>
        /// Sends a GET to '/api/'
        /// </summary>
        /// <returns></returns>
        public static RestOperation ListRootResources()
        {
            return new RestOperation("GET", "api/")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/agilerun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetAgileRun(string id, string expand = null)
        {
            return new RestOperation("GET", "api/agilerun/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/agilerun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateAgileRun(string id, CreateOrUpdateAgileRun model, string expand = null)
        {
            return new RestOperation("PUT", "api/agilerun/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/agilerun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteAgileRun(string id)
        {
            return new RestOperation("DELETE", "api/agilerun/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/agilerun/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAgileRunAllRelationships(string id)
        {
            return new RestOperation("GET", "api/agilerun/" + id + "/allrelationships")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/agilerun/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAgileRunRelationships(string id)
        {
            return new RestOperation("GET", "api/agilerun/" + id + "/relationships")
                { 
                };
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
        public static RestOperation SearchAgileRuns(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/agileruns")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/agileruns'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateAgileRun(CreateOrUpdateAgileRun model, string expand = null)
        {
            return new RestOperation("POST", "api/agileruns")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/assignedtosearch'
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation SearchForUsersGroupsAndSpecialUsers(string query = null, bool? valuesqry = null)
        {
            return new RestOperation("GET", "api/assignedtosearch")
                { 
                    QueryParams = 
                        {
                             {"query", query},
                             {"valuesqry", valuesqry},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/assignedtosearch'
        /// </summary>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <returns></returns>
        public static RestOperation SearchForUsersGroupsAndSpecialUsersUsingPostMethod(string query = null, string valuesqry = null)
        {
            return new RestOperation("POST", "api/assignedtosearch")
                { 
                    FormParams = 
                        {
                             {"query", query},
                             {"valuesqry", valuesqry},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/attachment/{id}/contents'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation RetrieveAttachmentContents(string id)
        {
            return new RestOperation("GET", "api/attachment/" + id + "/contents")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtest/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTest(string id, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtest/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/automatedtest/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateAutomatedTest(string id, CreateOrUpdateAutomatedTest model, string expand = null)
        {
            return new RestOperation("PUT", "api/automatedtest/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/automatedtest/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteAutomatedTest(string id)
        {
            return new RestOperation("DELETE", "api/automatedtest/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtest/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestAllRelationships(string id)
        {
            return new RestOperation("GET", "api/automatedtest/" + id + "/allrelationships")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtest/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRelationships(string id)
        {
            return new RestOperation("GET", "api/automatedtest/" + id + "/relationships")
                { 
                };
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
        public static RestOperation SearchAutomatedTestAssignmentsForAutomatedTest(string testId, string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtest/" + testId + "/assignments")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtest/{testId}/assignments'
        /// </summary>
        /// <param name="testId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateAssignmentForAutomatedTest(string testId, CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            return new RestOperation("POST", "api/automatedtest/" + testId + "/assignments")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestAssignment(string id, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtestassignment/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/automatedtestassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateAutomatedTestAssignment(string id, CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            return new RestOperation("PUT", "api/automatedtestassignment/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteAutomatedTestAssignment(string id)
        {
            return new RestOperation("DELETE", "api/automatedtestassignment/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestAssignmentAllRelationships(string id)
        {
            return new RestOperation("GET", "api/automatedtestassignment/" + id + "/allrelationships")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestassignment/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestAssignmentRelationships(string id)
        {
            return new RestOperation("GET", "api/automatedtestassignment/" + id + "/relationships")
                { 
                };
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
        public static RestOperation GetRunsForAutomatedTestAssignment(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/automatedtestassignment/" + id + "/runs")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtestassignment/{id}/runs'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTestRun(string id)
        {
            return new RestOperation("POST", "api/automatedtestassignment/" + id + "/runs")
                { 
                };
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
        public static RestOperation SearchAutomatedTestAssignments(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtestassignments")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtestassignments'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTestAssignment(CreateOrUpdateAutomatedTestAssignment model, string expand = null)
        {
            return new RestOperation("POST", "api/automatedtestassignments")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation GetAutomatedTestRun(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string tql = null, string timeZone = null)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"tql", tql},
                             {"timeZone", timeZone},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteAutomatedTestRun(string id)
        {
            return new RestOperation("DELETE", "api/automatedtestrun/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{id}/testdata'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRunData(string id)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + id + "/testdata")
                { 
                };
        }


        /// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/attachment/{attachmentId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="attachmentId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteAutomatedTestRunAttachment(string runId, string attachmentId)
        {
            return new RestOperation("DELETE", "api/automatedtestrun/" + runId + "/attachment/" + attachmentId + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/attachments'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRunAttachments(string runId)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + runId + "/attachments")
                { 
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/attachments'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTestRunAttachments(string runId)
        {
            return new RestOperation("POST", "api/automatedtestrun/" + runId + "/attachments")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRunNode(string runId, string nodeId, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + runId + "/node/" + nodeId + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PATCH to '/api/automatedtestrun/{runId}/node/{nodeId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation PatchAutomatedTestRunNode(string runId, string nodeId, EditResultNode model, string expand = null)
        {
            return new RestOperation("PATCH", "api/automatedtestrun/" + runId + "/node/" + nodeId + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/node/{nodeId}/attachment/{attachmentId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="attachmentId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteAutomatedTestRunNodeAttachment(string runId, string nodeId, string attachmentId)
        {
            return new RestOperation("DELETE", "api/automatedtestrun/" + runId + "/node/" + nodeId + "/attachment/" + attachmentId + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/attachments'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRunNodeAttachments(string runId, string nodeId)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + runId + "/node/" + nodeId + "/attachments")
                { 
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/node/{nodeId}/attachments'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTestRunNodeAttachments(string runId, string nodeId)
        {
            return new RestOperation("POST", "api/automatedtestrun/" + runId + "/node/" + nodeId + "/attachments")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/children'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="statuses">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRunNodeChildren(string runId, string nodeId, string statuses, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + runId + "/node/" + nodeId + "/children")
                { 
					Content = statuses,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/incident/{incidentId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="incidentId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRunNodeIncident(string runId, string nodeId, string incidentId, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + runId + "/node/" + nodeId + "/incident/" + incidentId + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestrun/{runId}/node/{nodeId}/incident/{incidentId}'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="incidentId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteAutomatedTestRunNodeIncident(string runId, string nodeId, string incidentId)
        {
            return new RestOperation("DELETE", "api/automatedtestrun/" + runId + "/node/" + nodeId + "/incident/" + incidentId + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/node/{nodeId}/incidents'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRunNodeIncidents(string runId, string nodeId, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + runId + "/node/" + nodeId + "/incidents")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtestrun/{runId}/node/{nodeId}/incidents'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="nodeId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTestRunNodeIncident(string runId, string nodeId, CreateAutomatedTestRunResultNodeIncident model)
        {
            return new RestOperation("POST", "api/automatedtestrun/" + runId + "/node/" + nodeId + "/incidents")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestrun/{runId}/nodes'
        /// </summary>
        /// <param name="runId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestRunRootNodes(string runId, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtestrun/" + runId + "/nodes")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation SearchAutomatedTestRuns(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtestruns")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation SearchAutomatedTests(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/automatedtests")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtests'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTest(CreateOrUpdateAutomatedTest model, string expand = null)
        {
            return new RestOperation("POST", "api/automatedtests")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestScheduleById(string id)
        {
            return new RestOperation("GET", "api/automatedtestschedule/" + id + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateAutomatedTestSchedule(string id, EditScheduleDTO dto)
        {
            return new RestOperation("PUT", "api/automatedtestschedule/" + id + "")
                { 
					Content = dto
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeletedAutomatedTestSchedule(string id)
        {
            return new RestOperation("DELETE", "api/automatedtestschedule/" + id + "")
                { 
                };
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
        public static RestOperation GetAutomatedTestScheduleConfigurations(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/automatedtestschedule/" + id + "/importconfigurations")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{id}/importconfigurations'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTestScheduleConfiguration(string id, EditScheduleConfigurationDTO dto)
        {
            return new RestOperation("POST", "api/automatedtestschedule/" + id + "/importconfigurations")
                { 
					Content = dto
                };
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
        public static RestOperation GetAutomatedTestScheduleScheduleConfigurations(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/automatedtestschedule/" + id + "/schedules")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{id}/schedules'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTestScheduleScheduleConfiguration(string id, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            return new RestOperation("POST", "api/automatedtestschedule/" + id + "/schedules")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetConfigurationForAutomatedTestSchedule(string scheduleId, string configId)
        {
            return new RestOperation("GET", "api/automatedtestschedule/" + scheduleId + "/importconfiguration/" + configId + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PATCH to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation PatchConfigurationForAutomatedTestSchedule(string scheduleId, string configId, PatchScheduleConfigurationDTO dto)
        {
            return new RestOperation("PATCH", "api/automatedtestschedule/" + scheduleId + "/importconfiguration/" + configId + "")
                { 
					Content = dto
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateConfigurationForAutomatedTestSchedule(string scheduleId, string configId, EditScheduleConfigurationDTO dto)
        {
            return new RestOperation("PUT", "api/automatedtestschedule/" + scheduleId + "/importconfiguration/" + configId + "")
                { 
					Content = dto
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{scheduleId}/importconfiguration/{configId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="configId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteConfigurationForAutomatedTestSchedule(string scheduleId, string configId)
        {
            return new RestOperation("DELETE", "api/automatedtestschedule/" + scheduleId + "/importconfiguration/" + configId + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId)
        {
            return new RestOperation("GET", "api/automatedtestschedule/" + scheduleId + "/schedule/" + scheduleConfigId + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PATCH to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation PatchAutomatedTestScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            return new RestOperation("PATCH", "api/automatedtestschedule/" + scheduleId + "/schedule/" + scheduleConfigId + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateAutomatedTestScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId, CreateOrUpdateAutomatedTestingScheduleInfo model)
        {
            return new RestOperation("PUT", "api/automatedtestschedule/" + scheduleId + "/schedule/" + scheduleConfigId + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteAutomatedTestScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId)
        {
            return new RestOperation("DELETE", "api/automatedtestschedule/" + scheduleId + "/schedule/" + scheduleConfigId + "")
                { 
                };
        }


        /// <summary>
        /// Sends a POST to '/api/automatedtestschedule/{scheduleId}/schedule/{scheduleConfigId}/run'
        /// </summary>
        /// <param name="scheduleId">a path parameter (no description)</param>
        /// <param name="scheduleConfigId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation TriggerAutomatedScheduleScheduleConfiguration(string scheduleId, string scheduleConfigId)
        {
            return new RestOperation("POST", "api/automatedtestschedule/" + scheduleId + "/schedule/" + scheduleConfigId + "/run")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtestschedules'
        /// </summary>
        /// <param name="projectId">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestSchedules(string projectId = null)
        {
            return new RestOperation("GET", "api/automatedtestschedules")
                { 
                    QueryParams = 
                        {
                             {"projectId", projectId},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/automatedtestschedules'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateAutomatedTestSchedule(CreateSchedule model)
        {
            return new RestOperation("POST", "api/automatedtestschedules")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/automatedtesttype/{name}'
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetAutomatedTestTypeByName(string name)
        {
            return new RestOperation("GET", "api/automatedtesttype/" + name + "")
                { 
                };
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
        public static RestOperation GetAutomatedTestTypes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/automatedtesttypes")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/backgroundtask/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetBackgroundTaskStatus(string id)
        {
            return new RestOperation("GET", "api/backgroundtask/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a POST to '/api/backgroundtasks'
        /// </summary>
        /// <param name="dto">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation StartBackgroundTask(CreateBackgroundTask dto)
        {
            return new RestOperation("POST", "api/backgroundtasks")
                { 
					Content = dto
                };
        }


        /// <summary>
        /// Sends a GET to '/api/customfield/{name}'
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetCustomField(string name)
        {
            return new RestOperation("GET", "api/customfield/" + name + "")
                { 
                };
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
        public static RestOperation SearchCustomFields(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/customfields")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/customfieldtype/{name}'
        /// </summary>
        /// <param name="name">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetCustomFieldType(string name)
        {
            return new RestOperation("GET", "api/customfieldtype/" + name + "")
                { 
                };
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
        public static RestOperation SearchCustomFieldTypes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/customfieldtypes")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/diagnostics/performancemeasurement/latest'
        /// </summary>
        /// <param name="export">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetLastPerformanceTestResults(bool? export = null)
        {
            return new RestOperation("GET", "api/diagnostics/performancemeasurement/latest")
                { 
                    QueryParams = 
                        {
                             {"export", export},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/executionpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetExecutionPackage(string id, string expand = null)
        {
            return new RestOperation("GET", "api/executionpackage/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/executionpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateExecutionPackage(string id, CreateOrUpdateExecutionPackage model, string expand = null)
        {
            return new RestOperation("PUT", "api/executionpackage/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/executionpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteExecutionPackage(string id)
        {
            return new RestOperation("DELETE", "api/executionpackage/" + id + "")
                { 
                };
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
        public static RestOperation GetExecutionPackageChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/executionpackage/" + id + "/children")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation SearchExecutionPackages(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/executionpackages")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/executionpackages'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateExecutionPackage(CreateOrUpdateExecutionPackage model, string expand = null)
        {
            return new RestOperation("POST", "api/executionpackages")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/exportfile/{filename}'
        /// </summary>
        /// <param name="filename">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetExportedFileContents(string filename)
        {
            return new RestOperation("GET", "api/exportfile/" + filename + "")
                { 
                };
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
        public static RestOperation GetExternalSourceByAttributes(string end = null, string key = null, string id = null, string projectId = null, string expand = null)
        {
            return new RestOperation("GET", "api/externalsourcemetadata")
                { 
                    QueryParams = 
                        {
                             {"end", end},
                             {"key", key},
                             {"id", id},
                             {"projectId", projectId},
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation SearchExternalSources(string compatibleWithKey = null, string end = null, string compatibleWithId = null, string projectId = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/externalsourcesmetadata")
                { 
                    QueryParams = 
                        {
                             {"compatibleWithKey", compatibleWithKey},
                             {"end", end},
                             {"compatibleWithId", compatibleWithId},
                             {"projectId", projectId},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/externalsystem/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetExternalSystem(string id, string expand = null)
        {
            return new RestOperation("GET", "api/externalsystem/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PATCH to '/api/externalsystem/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation PatchExternalSystem(string id, CreateOrUpdateExternalSystem model, string expand = null)
        {
            return new RestOperation("PATCH", "api/externalsystem/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/externalsystem/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateExternalSystem(string id, CreateOrUpdateExternalSystem model, string expand = null)
        {
            return new RestOperation("PUT", "api/externalsystem/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/externalsystem/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="keepReferences">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteExternalSystem(string id, bool? keepReferences = null)
        {
            return new RestOperation("DELETE", "api/externalsystem/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"keepReferences", keepReferences},
                        }
                };
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
        public static RestOperation GetExternalSystemLinksForSystem(string systemId, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/externalsystem/" + systemId + "/links")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/externalsystemlink/{externalSystemLinkId}/ticket/{ticketId}'
        /// </summary>
        /// <param name="ticketId">a path parameter (no description)</param>
        /// <param name="externalSystemLinkId">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetTicket(string ticketId, string externalSystemLinkId, string expand = null)
        {
            return new RestOperation("GET", "api/externalsystemlink/" + externalSystemLinkId + "/ticket/" + ticketId + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a POST to '/api/externalsystemlink/{externalSystemLinkId}/ticket/{ticketId}/link'
        /// </summary>
        /// <param name="ticketId">a path parameter (no description)</param>
        /// <param name="externalSystemLinkId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation StartCreateIncidentFromTicket(string ticketId, string externalSystemLinkId)
        {
            return new RestOperation("POST", "api/externalsystemlink/" + externalSystemLinkId + "/ticket/" + ticketId + "/link")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/externalsystemlink/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetExternalSystemLink(string id, string expand = null)
        {
            return new RestOperation("GET", "api/externalsystemlink/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PATCH to '/api/externalsystemlink/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation PatchExternalSystemLink(string id, EditExternalSystemLink model)
        {
            return new RestOperation("PATCH", "api/externalsystemlink/" + id + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/externalsystemlink/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="keepReferences">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteExternalSystemLink(string id, bool? keepReferences = null)
        {
            return new RestOperation("DELETE", "api/externalsystemlink/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"keepReferences", keepReferences},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/externalsystemlink/{linkId}/field/{fieldName}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="fieldName">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetOptionsForExternalSystemLinksField(string linkId, string fieldName, string query = null, bool? valuesqry = null)
        {
            return new RestOperation("GET", "api/externalsystemlink/" + linkId + "/field/" + fieldName + "")
                { 
                    QueryParams = 
                        {
                             {"query", query},
                             {"valuesqry", valuesqry},
                        }
                };
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
        public static RestOperation SearchExternalSystemLinks(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/externalsystemlinks")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/externalsystemlinks'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateExternalSystemLink(CreateExternalSystemLink model, string expand = null)
        {
            return new RestOperation("POST", "api/externalsystemlinks")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation SearchExternalSystems(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/externalsystems")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/externalsystems'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateExternalSystem(CreateOrUpdateExternalSystem model, string expand = null)
        {
            return new RestOperation("POST", "api/externalsystems")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/externalsystemtype/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetExternalSystemType(string id)
        {
            return new RestOperation("GET", "api/externalsystemtype/" + id + "")
                { 
                };
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
        public static RestOperation SearchExternalSystemTypes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/externalsystemtypes")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a POST to '/api/gridwidget/{widgetType}/data/{dataName}'
        /// </summary>
        /// <param name="widgetType">a path parameter (no description)</param>
        /// <param name="dataName">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetGridWidgetData(string widgetType, string dataName, GridWidgetContext model)
        {
            return new RestOperation("POST", "api/gridwidget/" + widgetType + "/data/" + dataName + "")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/gridwidgethost/{hostId}/project/{projectId}/position/{position}'
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="position">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetGridWidgetState(string hostId, string projectId, string position)
        {
            return new RestOperation("GET", "api/gridwidgethost/" + hostId + "/project/" + projectId + "/position/" + position + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/gridwidgethost/{hostId}/project/{projectId}/position/{position}'
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="position">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateGridWidgetState(string hostId, string projectId, string position, EditGridWidgetState model)
        {
            return new RestOperation("PUT", "api/gridwidgethost/" + hostId + "/project/" + projectId + "/position/" + position + "")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/gridwidgethost/{hostId}/project/{projectId}/positions'
        /// </summary>
        /// <param name="hostId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetGridWidgetStatesForHost(string hostId, string projectId)
        {
            return new RestOperation("GET", "api/gridwidgethost/" + hostId + "/project/" + projectId + "/positions")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/group/{groupId}/permissions/project/{projectId}'
        /// </summary>
        /// <param name="groupId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetGroupProjectPermissions(string groupId, string projectId)
        {
            return new RestOperation("GET", "api/group/" + groupId + "/permissions/project/" + projectId + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/group/{groupId}/permissions/project/{projectId}'
        /// </summary>
        /// <param name="groupId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateGroupProjectPermissions(string groupId, string projectId, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            return new RestOperation("PUT", "api/group/" + groupId + "/permissions/project/" + projectId + "")
                { 
					Content = assignments
                };
        }


        /// <summary>
        /// Sends a GET to '/api/group/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetGroup(string id, string expand = null)
        {
            return new RestOperation("GET", "api/group/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/group/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateGroup(string id, CreateOrUpdateGroup model)
        {
            return new RestOperation("PUT", "api/group/" + id + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/group/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteGroup(string id)
        {
            return new RestOperation("DELETE", "api/group/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/group/{id}/permissions/global'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetGlobalGroupPermissions(string id)
        {
            return new RestOperation("GET", "api/group/" + id + "/permissions/global")
                { 
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/group/{id}/permissions/global'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateGlobalGroupPermissions(string id, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            return new RestOperation("PUT", "api/group/" + id + "/permissions/global")
                { 
					Content = assignments
                };
        }


        /// <summary>
        /// Sends a GET to '/api/group/{id}/permissions/projects'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetProjectGroupPermissionLinks(string id)
        {
            return new RestOperation("GET", "api/group/" + id + "/permissions/projects")
                { 
                };
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
        public static RestOperation GetGroupMembers(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/group/" + id + "/users")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation SetGroupMembers(string id, GroupMemberships model, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("PUT", "api/group/" + id + "/users")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation SearchGroups(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/groups")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/groups'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateGroup(CreateOrUpdateGroup model)
        {
            return new RestOperation("POST", "api/groups")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/groupssearch'
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation SearchGroupsByPartialName(string query = null, bool? valuesqry = null, string expand = null)
        {
            return new RestOperation("GET", "api/groupssearch")
                { 
                    QueryParams = 
                        {
                             {"query", query},
                             {"valuesqry", valuesqry},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/groupssearch'
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public static RestOperation SearchGroupsByPartialNameUsingPostMethod(string valuesqry = null, string query = null, string expand = null)
        {
            return new RestOperation("POST", "api/groupssearch")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
 ,                     FormParams = 
                        {
                             {"valuesqry", valuesqry},
                             {"query", query},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/incident/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetIncident(string id, string expand = null)
        {
            return new RestOperation("GET", "api/incident/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/incident/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateIncident(string id, CreateOrUpdateIncident model, string expand = null)
        {
            return new RestOperation("PUT", "api/incident/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/incident/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteIncident(string id)
        {
            return new RestOperation("DELETE", "api/incident/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/incident/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetIncidentAllRelationships(string id)
        {
            return new RestOperation("GET", "api/incident/" + id + "/allrelationships")
                { 
                };
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
        public static RestOperation GetIncidentComments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/incident/" + id + "/comments")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/incident/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetIncidentRelationships(string id)
        {
            return new RestOperation("GET", "api/incident/" + id + "/relationships")
                { 
                };
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
        public static RestOperation SearchIncidents(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/incidents")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/incidents'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateIncident(CreateOrUpdateIncident model, string expand = null)
        {
            return new RestOperation("POST", "api/incidents")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/mailqueue/messages'
        /// </summary>
        /// <returns></returns>
        public static RestOperation GetQueuedMailMessages()
        {
            return new RestOperation("GET", "api/mailqueue/messages")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/mailsender/default/settings'
        /// </summary>
        /// <returns></returns>
        public static RestOperation GetMailSenderSettings()
        {
            return new RestOperation("GET", "api/mailsender/default/settings")
                { 
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/mailsender/default/settings'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateMailSenderSettings(MailSenderSettings model)
        {
            return new RestOperation("PUT", "api/mailsender/default/settings")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/organisation/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetOrganisation(string id, string expand = null)
        {
            return new RestOperation("GET", "api/organisation/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/organisation/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateOrganisation(string id, CreateOrUpdateOrganisation model, string expand = null)
        {
            return new RestOperation("PUT", "api/organisation/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/organisation/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation StartDeleteOrganisation(string id)
        {
            return new RestOperation("DELETE", "api/organisation/" + id + "")
                { 
                };
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
        public static RestOperation GetRelationshipTypesByKey(string id, string key, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/organisation/" + id + "/relationshiptype/" + key + "")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation CreateRelationship(string id, string key, CreateRelationship model, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("POST", "api/organisation/" + id + "/relationshiptype/" + key + "/relationships")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation GetRelationshipTypes(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/organisation/" + id + "/relationshiptypes")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/picklist/{type}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetOrganisationPicklistValues(string organisationId, string type)
        {
            return new RestOperation("GET", "api/organisation/" + organisationId + "/picklist/" + type + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/picklistsearch/{type}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation SearchOrganisationPicklistValues(string organisationId, string type, string query = null, bool? valuesqry = null)
        {
            return new RestOperation("GET", "api/organisation/" + organisationId + "/picklistsearch/" + type + "")
                { 
                    QueryParams = 
                        {
                             {"query", query},
                             {"valuesqry", valuesqry},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/organisation/{organisationId}/picklistsearch/{type}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public static RestOperation SearchOrganisationPicklistValuesUsingPostMethod(string organisationId, string type, string valuesqry = null, string query = null)
        {
            return new RestOperation("POST", "api/organisation/" + organisationId + "/picklistsearch/" + type + "")
                { 
                    FormParams = 
                        {
                             {"valuesqry", valuesqry},
                             {"query", query},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetRelationship(string organisationId, string key, string id)
        {
            return new RestOperation("GET", "api/organisation/" + organisationId + "/relationshiptype/" + key + "/relationship/" + id + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateRelationship(string organisationId, string key, string id, UpdateRelationship model)
        {
            return new RestOperation("PUT", "api/organisation/" + organisationId + "/relationshiptype/" + key + "/relationship/" + id + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/organisation/{organisationId}/relationshiptype/{key}/relationship/{id}'
        /// </summary>
        /// <param name="organisationId">a path parameter (no description)</param>
        /// <param name="key">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteRelationship(string organisationId, string key, string id)
        {
            return new RestOperation("DELETE", "api/organisation/" + organisationId + "/relationshiptype/" + key + "/relationship/" + id + "")
                { 
                };
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
        public static RestOperation SearchOrganisations(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/organisations")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/organisations'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateOrganisation(CreateOrUpdateOrganisation model, string expand = null)
        {
            return new RestOperation("POST", "api/organisations")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/permission/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetPermission(string id)
        {
            return new RestOperation("GET", "api/permission/" + id + "")
                { 
                };
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
        public static RestOperation GetAllPermissions(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/permissions")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/project/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetProject(string id, string expand = null)
        {
            return new RestOperation("GET", "api/project/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/project/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateProject(string id, CreateOrUpdateProject model, string expand = null)
        {
            return new RestOperation("PUT", "api/project/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/project/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation StartProjectDelete(string id)
        {
            return new RestOperation("DELETE", "api/project/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/project/{projectId}/assignees'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation SearchProjectAssignees(string projectId, string query = null, string expand = null)
        {
            return new RestOperation("GET", "api/project/" + projectId + "/assignees")
                { 
                    QueryParams = 
                        {
                             {"query", query},
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation GetProjectPicklistValues(string projectId, string type, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/project/" + projectId + "/picklist/" + type + "")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/project/{projectId}/picklistsearch/{type}'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation SearchProjectPicklistValues(string projectId, string type, string query = null, bool? valuesqry = null)
        {
            return new RestOperation("GET", "api/project/" + projectId + "/picklistsearch/" + type + "")
                { 
                    QueryParams = 
                        {
                             {"query", query},
                             {"valuesqry", valuesqry},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/project/{projectId}/picklistsearch/{type}'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="type">a path parameter (no description)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public static RestOperation SearchProjectPicklistValuesUsingPostMethod(string projectId, string type, string valuesqry = null, string query = null)
        {
            return new RestOperation("POST", "api/project/" + projectId + "/picklistsearch/" + type + "")
                { 
                    FormParams = 
                        {
                             {"valuesqry", valuesqry},
                             {"query", query},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/project/{projectId}/tickets'
        /// </summary>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="q">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation SearchTickets(string projectId, string q = null, string expand = null)
        {
            return new RestOperation("GET", "api/project/" + projectId + "/tickets")
                { 
                    QueryParams = 
                        {
                             {"q", q},
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation SearchAllProjectCategories(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/projectcategories")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/projectcategories'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateProjectCategory(CreateOrUpdateProjectCategory model, string expand = null)
        {
            return new RestOperation("POST", "api/projectcategories")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/projectcategory/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetProjectCategory(string id, string expand = null)
        {
            return new RestOperation("GET", "api/projectcategory/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/projectcategory/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateProjectCategory(string id, CreateOrUpdateProjectCategory model, string expand = null)
        {
            return new RestOperation("PUT", "api/projectcategory/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/projectcategory/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteProjectCategory(string id)
        {
            return new RestOperation("DELETE", "api/projectcategory/" + id + "")
                { 
                };
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
        public static RestOperation GetProjectCategoriesChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/projectcategory/" + id + "/children")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation SearchProjects(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/projects")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/projects'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateProject(CreateOrUpdateProject model, string expand = null)
        {
            return new RestOperation("POST", "api/projects")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/projectssearch'
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation SearchProjectsByPartialName(string query = null, bool? valuesqry = null, string expand = null)
        {
            return new RestOperation("GET", "api/projectssearch")
                { 
                    QueryParams = 
                        {
                             {"query", query},
                             {"valuesqry", valuesqry},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/projectssearch'
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public static RestOperation SearchProjectsByPartialNameUsingPostMethod(string valuesqry = null, string query = null, string expand = null)
        {
            return new RestOperation("POST", "api/projectssearch")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
 ,                     FormParams = 
                        {
                             {"valuesqry", valuesqry},
                             {"query", query},
                        }
                };
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
        public static RestOperation SearchProjectTemplates(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/projecttemplates")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation GetAllRelationshipTypes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/relationshiptypes")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetRequirement(string id, string expand = null)
        {
            return new RestOperation("GET", "api/requirement/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/requirement/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateExistingRequirement(string id, CreateOrUpdateRequirement model, string expand = null)
        {
            return new RestOperation("PUT", "api/requirement/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/requirement/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteRequirement(string id)
        {
            return new RestOperation("DELETE", "api/requirement/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetRequirementAllRelationships(string id)
        {
            return new RestOperation("GET", "api/requirement/" + id + "/allrelationships")
                { 
                };
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
        public static RestOperation GetRequirementAttachments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/requirement/" + id + "/attachments")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/requirement/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateRequirementAttachment(string id)
        {
            return new RestOperation("POST", "api/requirement/" + id + "/attachments")
                { 
                };
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
        public static RestOperation GetRequirementsChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/requirement/" + id + "/children")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation GetExternalTicketComments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/requirement/" + id + "/comments")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/requirement/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetRequirementRelationships(string id)
        {
            return new RestOperation("GET", "api/requirement/" + id + "/relationships")
                { 
                };
        }


        /// <summary>
        /// Sends a DELETE to '/api/requirement/{requirementId}/attachment/{id}'
        /// </summary>
        /// <param name="requirementId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteRequirementAttachment(string requirementId, string id)
        {
            return new RestOperation("DELETE", "api/requirement/" + requirementId + "/attachment/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/requirementpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetRequirementPackage(string id, string expand = null)
        {
            return new RestOperation("GET", "api/requirementpackage/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/requirementpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateRequirementPackage(string id, CreateOrUpdateRequirementPackage model, string expand = null)
        {
            return new RestOperation("PUT", "api/requirementpackage/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/requirementpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteRequirementPackage(string id)
        {
            return new RestOperation("DELETE", "api/requirementpackage/" + id + "")
                { 
                };
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
        public static RestOperation GetRequirementPackageChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/requirementpackage/" + id + "/children")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation GetRequirementPackages(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/requirementpackages")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/requirementpackages'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateRequirementPackage(CreateOrUpdateRequirementPackage model, string expand = null)
        {
            return new RestOperation("POST", "api/requirementpackages")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation SearchRequirements(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/requirements")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/requirements'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateRequirement(CreateOrUpdateRequirement model, string expand = null)
        {
            return new RestOperation("POST", "api/requirements")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/script/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetScript(string id, string expand = null)
        {
            return new RestOperation("GET", "api/script/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/script/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateScript(string id, CreateOrUpdateScript model, string expand = null)
        {
            return new RestOperation("PUT", "api/script/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/script/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteScript(string id)
        {
            return new RestOperation("DELETE", "api/script/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/script/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetScriptAllRelationships(string id)
        {
            return new RestOperation("GET", "api/script/" + id + "/allrelationships")
                { 
                };
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
        public static RestOperation GetScriptAttachments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/script/" + id + "/attachments")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/script/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateScriptAttachment(string id)
        {
            return new RestOperation("POST", "api/script/" + id + "/attachments")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/script/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetScriptRelationships(string id)
        {
            return new RestOperation("GET", "api/script/" + id + "/relationships")
                { 
                };
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
        public static RestOperation GetAssignmentsForScript(string scriptId, string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/script/" + scriptId + "/assignments")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/script/{scriptId}/assignments'
        /// </summary>
        /// <param name="scriptId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateAssignmentForScript(string scriptId, CreateOrUpdateScriptAssignment model, string expand = null)
        {
            return new RestOperation("POST", "api/script/" + scriptId + "/assignments")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a DELETE to '/api/script/{scriptId}/attachment/{id}'
        /// </summary>
        /// <param name="scriptId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteScriptAttachment(string scriptId, string id)
        {
            return new RestOperation("DELETE", "api/script/" + scriptId + "/attachment/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetScriptAssignment(string id, string expand = null)
        {
            return new RestOperation("GET", "api/scriptassignment/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/scriptassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateScriptAssignment(string id, CreateOrUpdateScriptAssignment model, string expand = null)
        {
            return new RestOperation("PUT", "api/scriptassignment/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/scriptassignment/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteScriptAssignment(string id)
        {
            return new RestOperation("DELETE", "api/scriptassignment/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}/allrelationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetScriptAssignmentAllRelationships(string id)
        {
            return new RestOperation("GET", "api/scriptassignment/" + id + "/allrelationships")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/scriptassignment/{id}/relationships'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetScriptAssignmentRelationships(string id)
        {
            return new RestOperation("GET", "api/scriptassignment/" + id + "/relationships")
                { 
                };
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
        public static RestOperation SearchScriptRunsForScriptAssignment(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/scriptassignment/" + id + "/runs")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/scriptassignment/{id}/runs'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateScriptRunForScriptAssignment(string id, CreateNewRun model, string expand = null)
        {
            return new RestOperation("POST", "api/scriptassignment/" + id + "/runs")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation SearchScriptAssignments(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/scriptassignments")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/scriptassignments'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateScriptAssignment(CreateOrUpdateScriptAssignment model, string expand = null)
        {
            return new RestOperation("POST", "api/scriptassignments")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/scriptpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetScriptPackage(string id, string expand = null)
        {
            return new RestOperation("GET", "api/scriptpackage/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/scriptpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateScriptPackage(string id, CreateOrUpdateScriptPackage model, string expand = null)
        {
            return new RestOperation("PUT", "api/scriptpackage/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/scriptpackage/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteScriptPackage(string id)
        {
            return new RestOperation("DELETE", "api/scriptpackage/" + id + "")
                { 
                };
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
        public static RestOperation GetScriptPackagesChildren(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/scriptpackage/" + id + "/children")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation SearchScriptPackages(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/scriptpackages")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/scriptpackages'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateScriptPackage(CreateOrUpdateScriptPackage model, string expand = null)
        {
            return new RestOperation("POST", "api/scriptpackages")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/scriptrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetScriptRun(string id, string expand = null)
        {
            return new RestOperation("GET", "api/scriptrun/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/scriptrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation UpdateScriptRun(string id, UpdateScriptRun model, string expand = null)
        {
            return new RestOperation("PUT", "api/scriptrun/" + id + "")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/scriptrun/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteScriptRun(string id)
        {
            return new RestOperation("DELETE", "api/scriptrun/" + id + "")
                { 
                };
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
        public static RestOperation SearchScriptRuns(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/scriptruns")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation SearchScripts(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null, string expand = null)
        {
            return new RestOperation("GET", "api/scripts")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/scripts'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation CreateScript(CreateOrUpdateScript model, string expand = null)
        {
            return new RestOperation("POST", "api/scripts")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation Search(string tql = null, string indexName = null, string format = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null)
        {
            return new RestOperation("GET", "api/search")
                { 
                    QueryParams = 
                        {
                             {"tql", tql},
                             {"indexName", indexName},
                             {"format", format},
                             {"timeZone", timeZone},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                        }
                };
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
        public static RestOperation SearchUsingPostMethod(string tql = null, string timeZone = null, int? top = null, int? skip = null, string inlinecount = null)
        {
            return new RestOperation("POST", "api/search")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                        }
 ,                     FormParams = 
                        {
                             {"tql", tql},
                             {"timeZone", timeZone},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/search/index/{indexName}'
        /// </summary>
        /// <param name="indexName">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetSearchIndex(string indexName)
        {
            return new RestOperation("GET", "api/search/index/" + indexName + "")
                { 
                };
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
        public static RestOperation GetSearchIndexes(int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/search/indexes")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/stepresult/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetStepResult(string id, string expand = null)
        {
            return new RestOperation("GET", "api/stepresult/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
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
        public static RestOperation GetStepResultAttachments(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/stepresult/" + id + "/attachments")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/stepresult/{id}/attachments'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateStepResultAttachment(string id)
        {
            return new RestOperation("POST", "api/stepresult/" + id + "/attachments")
                { 
                };
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
        public static RestOperation GetStepResultIncidentLinks(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/stepresult/" + id + "/incidents")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/stepresult/{id}/incidents'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateStepResultIncidentLink(string id, CreateStepRunResultIncident model)
        {
            return new RestOperation("POST", "api/stepresult/" + id + "/incidents")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a DELETE to '/api/stepresult/{stepResultId}/attachment/{id}'
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteStepResultAttachment(string stepResultId, string id)
        {
            return new RestOperation("DELETE", "api/stepresult/" + stepResultId + "/attachment/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/stepresult/{stepResultId}/incident/{id}'
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetStepResultIncidentLink(string stepResultId, string id)
        {
            return new RestOperation("GET", "api/stepresult/" + stepResultId + "/incident/" + id + "")
                { 
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/stepresult/{stepResultId}/incident/{id}'
        /// </summary>
        /// <param name="stepResultId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteStepResultIncidentLink(string stepResultId, string id)
        {
            return new RestOperation("DELETE", "api/stepresult/" + stepResultId + "/incident/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/swagger'
        /// </summary>
        /// <returns></returns>
        public static RestOperation GetSwaggerAPIList()
        {
            return new RestOperation("GET", "api/swagger")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/swagger/api'
        /// </summary>
        /// <returns></returns>
        public static RestOperation GetSwaggerForCoreAPI()
        {
            return new RestOperation("GET", "api/swagger/api")
                { 
                };
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
        public static RestOperation GetSynchronizerSchedules(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/synchronizer/" + id + "/schedules")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/synchronizer/{id}/schedules'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateSynchronizerSchedule(string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            return new RestOperation("POST", "api/synchronizer/" + id + "/schedules")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/synchronizer/{linkId}/schedule/{id}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetLinkSynchronizationSchedule(string linkId, string id)
        {
            return new RestOperation("GET", "api/synchronizer/" + linkId + "/schedule/" + id + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PATCH to '/api/synchronizer/{linkId}/schedule/{id}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation PatchLinkSynchronizationSchedule(string linkId, string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            return new RestOperation("PATCH", "api/synchronizer/" + linkId + "/schedule/" + id + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/synchronizer/{linkId}/schedule/{id}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateLinkSynchronizationSchedule(string linkId, string id, CreateOrUpdateSynchronizationScheduleInfo model)
        {
            return new RestOperation("PUT", "api/synchronizer/" + linkId + "/schedule/" + id + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/synchronizer/{linkId}/schedule/{id}'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteLinkSynchronizationSchedule(string linkId, string id)
        {
            return new RestOperation("DELETE", "api/synchronizer/" + linkId + "/schedule/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a POST to '/api/synchronizer/{linkId}/schedule/{id}/run'
        /// </summary>
        /// <param name="linkId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation StartScheduleSynchronizing(string linkId, string id)
        {
            return new RestOperation("POST", "api/synchronizer/" + linkId + "/schedule/" + id + "/run")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/systemevent/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetSystemEvent(string id)
        {
            return new RestOperation("GET", "api/systemevent/" + id + "")
                { 
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/systemevent/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteSystemEvent(string id)
        {
            return new RestOperation("DELETE", "api/systemevent/" + id + "")
                { 
                };
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
        public static RestOperation GetSystemEvents(string fileName = null, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/systemevents")
                { 
                    QueryParams = 
                        {
                             {"fileName", fileName},
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/systemevents'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation AddSystemEvent(CreateOrUpdateSystemEvent model)
        {
            return new RestOperation("POST", "api/systemevents")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/systemevents'
        /// </summary>
        /// <param name="linkId">a query parameter (no description)</param>
        /// <param name="documentId">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteSystemEventsForLink(string linkId = null, string documentId = null)
        {
            return new RestOperation("DELETE", "api/systemevents")
                { 
                    QueryParams = 
                        {
                             {"linkId", linkId},
                             {"documentId", documentId},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/systeminfo'
        /// </summary>
        /// <returns></returns>
        public static RestOperation GetSystemInformation()
        {
            return new RestOperation("GET", "api/systeminfo")
                { 
                };
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
        public static RestOperation GetTemporaryAttachmentsForSet(string id, int? top = null, int? skip = null, string inlinecount = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/temporaryattachmentset/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/temporaryattachmentset/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UploadAttachments(string id)
        {
            return new RestOperation("POST", "api/temporaryattachmentset/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a DELETE to '/api/temporaryattachmentset/{setId}/attachment/{id}'
        /// </summary>
        /// <param name="setId">a path parameter (no description)</param>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteTemporaryAttachmentFromSet(string setId, string id)
        {
            return new RestOperation("DELETE", "api/temporaryattachmentset/" + setId + "/attachment/" + id + "")
                { 
                };
        }


        /// <summary>
        /// Sends a POST to '/api/temporaryattachmentsets'
        /// </summary>
        /// <returns></returns>
        public static RestOperation CreateTemporaryAttachmentSet()
        {
            return new RestOperation("POST", "api/temporaryattachmentsets")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/timezone'
        /// </summary>
        /// <param name="id">a query parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetTimezoneInformation(string id = null)
        {
            return new RestOperation("GET", "api/timezone")
                { 
                    QueryParams = 
                        {
                             {"id", id},
                        }
                };
        }


        /// <summary>
        /// Sends a GET to '/api/user/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation GetUser(string id, string expand = null)
        {
            return new RestOperation("GET", "api/user/" + id + "")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/user/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation UpdateUser(string id, CreateOrUpdateUser model)
        {
            return new RestOperation("PUT", "api/user/" + id + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/user/{id}'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteUser(string id)
        {
            return new RestOperation("DELETE", "api/user/" + id + "")
                { 
                };
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
        public static RestOperation GetUsersGroups(string id, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/user/" + id + "/groups")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
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
        public static RestOperation SetGroupMembershipsForUser(string id, GroupMemberships model, int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("PUT", "api/user/" + id + "/groups")
                { 
					Content = model,                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }


        /// <summary>
        /// Sends a PUT to '/api/user/{id}/password'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation SetUserPassword(string id, SetPassword model)
        {
            return new RestOperation("PUT", "api/user/" + id + "/password")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/user/{id}/permissions/global'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetGlobalUserPermissions(string id)
        {
            return new RestOperation("GET", "api/user/" + id + "/permissions/global")
                { 
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/user/{id}/permissions/global'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation SetGlobalPermissionsForUser(string id, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            return new RestOperation("PUT", "api/user/" + id + "/permissions/global")
                { 
					Content = assignments
                };
        }


        /// <summary>
        /// Sends a GET to '/api/user/{id}/permissions/projects'
        /// </summary>
        /// <param name="id">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetProjectUserPermissionLinks(string id)
        {
            return new RestOperation("GET", "api/user/" + id + "/permissions/projects")
                { 
                };
        }


        /// <summary>
        /// Sends a POST to '/api/user/{userId}/mailmessages'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation EnqueueMailMessage(string userId, Message model)
        {
            return new RestOperation("POST", "api/user/" + userId + "/mailmessages")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/user/{userId}/notification/{notificationId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetNotificationMessage(string userId, string notificationId)
        {
            return new RestOperation("GET", "api/user/" + userId + "/notification/" + notificationId + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PATCH to '/api/user/{userId}/notification/{notificationId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation PatchNotificationMessage(string userId, string notificationId, UpdateNotification model)
        {
            return new RestOperation("PATCH", "api/user/" + userId + "/notification/" + notificationId + "")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/user/{userId}/notification/{notificationId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="notificationId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation DeleteNotificationMessage(string userId, string notificationId)
        {
            return new RestOperation("DELETE", "api/user/" + userId + "/notification/" + notificationId + "")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/user/{userId}/notifications'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetNotificationsMessagesForUser(string userId)
        {
            return new RestOperation("GET", "api/user/" + userId + "/notifications")
                { 
                };
        }

        /// <summary>
        /// Sends a POST to '/api/user/{userId}/notifications'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateNotificationMessage(string userId, CreateNotification model)
        {
            return new RestOperation("POST", "api/user/" + userId + "/notifications")
                { 
					Content = model
                };
        }

        /// <summary>
        /// Sends a DELETE to '/api/user/{userId}/notifications'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation ClearNotificationMessagesForUser(string userId)
        {
            return new RestOperation("DELETE", "api/user/" + userId + "/notifications")
                { 
                };
        }


        /// <summary>
        /// Sends a GET to '/api/user/{userId}/permissions/project/{projectId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation GetUserProjectPermissions(string userId, string projectId)
        {
            return new RestOperation("GET", "api/user/" + userId + "/permissions/project/" + projectId + "")
                { 
                };
        }

        /// <summary>
        /// Sends a PUT to '/api/user/{userId}/permissions/project/{projectId}'
        /// </summary>
        /// <param name="userId">a path parameter (no description)</param>
        /// <param name="projectId">a path parameter (no description)</param>
        /// <param name="assignments">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation SetUserProjectPermissions(string userId, string projectId, List<CreateOrUpdatePermissionAssignment> assignments)
        {
            return new RestOperation("PUT", "api/user/" + userId + "/permissions/project/" + projectId + "")
                { 
					Content = assignments
                };
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
        public static RestOperation SearchUsers(int? top = null, int? skip = null, string inlinecount = null, string expand = null, string filter = null, string orderby = null)
        {
            return new RestOperation("GET", "api/users")
                { 
                    QueryParams = 
                        {
                             {"$top", top},
                             {"$skip", skip},
                             {"$inlinecount", inlinecount},
                             {"$expand", expand},
                             {"$filter", filter},
                             {"$orderby", orderby},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/users'
        /// </summary>
        /// <param name="model">a body parameter (no description)</param>
        /// <returns></returns>
        public static RestOperation CreateUser(CreateOrUpdateUser model)
        {
            return new RestOperation("POST", "api/users")
                { 
					Content = model
                };
        }


        /// <summary>
        /// Sends a GET to '/api/userssearch'
        /// </summary>
        /// <param name="query">a query parameter (no description)</param>
        /// <param name="valuesqry">a query parameter (no description)</param>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <returns></returns>
        public static RestOperation SearchUsersByPartialName(string query = null, bool? valuesqry = null, string expand = null)
        {
            return new RestOperation("GET", "api/userssearch")
                { 
                    QueryParams = 
                        {
                             {"query", query},
                             {"valuesqry", valuesqry},
                             {"$expand", expand},
                        }
                };
        }

        /// <summary>
        /// Sends a POST to '/api/userssearch'
        /// </summary>
        /// <param name="expand">a query parameter (Allows the specifying of eager-loading of related data which is returned in-line within the results of the request.)</param>
        /// <param name="valuesqry">a form parameter (Query to retreive a set of matches based on their values (values are separated by a pipe '|' character))</param>
        /// <param name="query">a form parameter (Partial name to match on)</param>
        /// <returns></returns>
        public static RestOperation SearchUsersByPartialNameUsingPostMethod(string valuesqry = null, string query = null, string expand = null)
        {
            return new RestOperation("POST", "api/userssearch")
                { 
                    QueryParams = 
                        {
                             {"$expand", expand},
                        }
 ,                     FormParams = 
                        {
                             {"valuesqry", valuesqry},
                             {"query", query},
                        }
                };
        }


    }
}


