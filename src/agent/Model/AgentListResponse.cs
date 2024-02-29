/*
 * agent/service.proto
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: version not set
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = agent.Client.OpenAPIDateConverter;

namespace agent.Model
{
    /// <summary>
    /// AgentListResponse
    /// </summary>
    [DataContract(Name = "agentListResponse")]
    public partial class AgentListResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgentListResponse" /> class.
        /// </summary>
        /// <param name="agents">agents.</param>
        /// <param name="pageToken">pageToken.</param>
        public AgentListResponse(List<AgentAgentEntity> agents = default(List<AgentAgentEntity>), string pageToken = default(string))
        {
            this.Agents = agents;
            this.PageToken = pageToken;
        }

        /// <summary>
        /// Gets or Sets Agents
        /// </summary>
        [DataMember(Name = "agents", EmitDefaultValue = false)]
        public List<AgentAgentEntity> Agents { get; set; }

        /// <summary>
        /// Gets or Sets PageToken
        /// </summary>
        [DataMember(Name = "pageToken", EmitDefaultValue = false)]
        public string PageToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgentListResponse {\n");
            sb.Append("  Agents: ").Append(Agents).Append("\n");
            sb.Append("  PageToken: ").Append(PageToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}