using DataForSeo.Client.Models;

namespace DataForSeo.Client.Models.Responses
{
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class DataforseoLabsCategoriesResultInfo
    {
        /// <summary>
        /// category code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CategoryCode { get; set; }

        /// <summary>
        /// full name of the category
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CategoryName { get; set; }

        /// <summary>
        /// the code of the superordinate category
        /// <br/>example:
        /// <br/>"category_code": 10178,
        /// <br/>"category_name": "Apparel Accessories",
        /// <br/>"category_code_parent": 10021
        /// <br/>where category_code_parent
        /// <br/>corresponds to:
        /// <br/>"category_code": 10021,
        /// <br/>"category_name": "Apparel"
        /// <br/>"category_code_parent": null
        /// </summary>
        [Newtonsoft.Json.JsonProperty("category_code_parent", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CategoryCodeParent { get; set; }

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