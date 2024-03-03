using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Requests
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class BacklinksDomainPagesSummaryLiveRequestInfo
    {
        /// <summary>
        /// domain, subdomain or webpage to get summary data for
        /// <br/>required field
        /// <br/>a domain or a subdomain should be specified without https:// and www.
        /// <br/>a page should be specified with absolute URL (including http:// or https://)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("target", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Target { get; set; }

        /// <summary>
        /// the maximum number of returned anchors
        /// <br/>optional field
        /// <br/>default value: 100
        /// <br/>maximum value: 1000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// offset in the results array of returned anchors
        /// <br/>optional field
        /// <br/>default value: 0
        /// <br/>if you specify the 10 value, the first ten anchors in the results array will be omitted and the data will be provided for the successive anchors
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offset", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// maximum number of elements within internal arrays
        /// <br/>optional field
        /// <br/>you can use this field to limit the number of elements within the following arrays:
        /// <br/>referring_links_tld
        /// <br/>referring_links_types
        /// <br/>referring_links_attributes
        /// <br/>referring_links_platform_types
        /// <br/>referring_links_semantic_locations
        /// <br/>default value: 10
        /// <br/>maximum value: 1000
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internal_list_limit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? InternalListLimit { get; set; }

        /// <summary>
        /// set what backlinks to return and count
        /// <br/>optional field
        /// <br/>you can use this field to choose what backlinks will be returned and used for aggregated metrics for your target;
        /// <br/>possible values:
        /// <br/>all – all backlinks will be returned and counted;
        /// <br/>live – backlinks found during the last check will be returned and counted;
        /// <br/>lost – lost backlinks will be returned and counted;
        /// <br/>default value: live
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks_status_type", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BacklinksStatusType { get; set; }

        /// <summary>
        /// array of results filtering parameters
        /// <br/>optional field
        /// <br/>you can add several filters at once (8 filters maximum)
        /// <br/>you should set a logical operator and, or between the conditions
        /// <br/>the following operators are supported:
        /// <br/>regex, =, &lt; &gt;, in, not_in, like, not_like, ilike, not_ilike
        /// <br/>you can use the % operator with like and not_like to match any string of zero or more characters
        /// <br/>example:
        /// <br/>["referring_links_types.anchors","&gt;","1"]
        /// <br/>[["broken_pages","&gt;","2"],
        /// <br/>"and",
        /// <br/>["backlinks","&gt;","10"]]
        /// <br/>[["first_seen","&gt;","2017-10-23 11:31:45 +00:00"],
        /// <br/>"and",
        /// <br/>[["anchor","like","%seo%"],"or",["referring_domains","&gt;","10"]]]
        /// <br/>The full list of possible filters is available here.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("filters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> Filters { get; set; }

        /// <summary>
        /// results sorting rules
        /// <br/>optional field
        /// <br/>you can use the same values as in the filters array to sort the results
        /// <br/>possible sorting types:
        /// <br/>asc – results will be sorted in the ascending order
        /// <br/>desc – results will be sorted in the descending order
        /// <br/>you should use a comma to set up a sorting type
        /// <br/>example:
        /// <br/>["backlinks,desc"]
        /// <br/>note that you can set no more than three sorting rules in a single request
        /// <br/>you should use a comma to separate several sorting rules
        /// <br/>example:
        /// <br/>["backlinks,desc","rank,asc"]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_by", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> OrderBy { get; set; }

        /// <summary>
        /// filter the backlinks of your target
        /// <br/>optional field
        /// <br/>you can use this field to filter the initial backlinks that will be included in the dataset for aggregated metrics for your target
        /// <br/>you can filter the backlinks by all fields available in the response of this endpoint
        /// <br/>using this parameter, you can include only dofollow backlinks in the response and create a flexible backlinks dataset to calculate the metrics for
        /// <br/>example:
        /// <br/>"backlinks_filters": [["dofollow", "=", true]]
        /// </summary>
        [Newtonsoft.Json.JsonProperty("backlinks_filters", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<object> BacklinksFilters { get; set; }

        /// <summary>
        /// indicates if the subdomains of the target will be included in the search
        /// <br/>optional field
        /// <br/>if set to false, the subdomains will be ignored
        /// <br/>default value: true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_subdomains", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeSubdomains { get; set; }

        /// <summary>
        /// indicates if indirect links to the target will be included in the results
        /// <br/>optional field
        /// <br/>if set to true, the results will include data on indirect links pointing to a page that either redirects to the target, or points to a canonical page
        /// <br/>if set to false, indirect links will be ignored
        /// <br/>default value: true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("include_indirect_links", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IncludeIndirectLinks { get; set; }

        /// <summary>
        /// indicates whether the backlinks from subdomains of the target are excluded
        /// <br/>optional field
        /// <br/>if set to false, the backlinks from subdomains of the target will be ommited and you won’t receive the same domain in the response;
        /// <br/>default value: true
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exclude_internal_backlinks", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? ExcludeInternalBacklinks { get; set; }

        /// <summary>
        /// user-defined task identifier
        /// <br/>optional field
        /// <br/>the character limit is 255
        /// <br/>you can use this parameter to identify the task and match it with the result
        /// <br/>you will find the specified tag value in the data object of the response
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tag", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Tag { get; set; }

        private System.Collections.Generic.IDictionary<string, object> _additionalProperties;
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get
            {
                return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>());
            }

            set
            {
                _additionalProperties = value;
            }
        }
    }
}