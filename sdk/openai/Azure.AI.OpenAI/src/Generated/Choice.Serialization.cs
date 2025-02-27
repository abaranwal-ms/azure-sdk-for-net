// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    public partial class Choice
    {
        internal static Choice DeserializeChoice(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string text = default;
            int index = default;
            Optional<ContentFilterResults> contentFilterResults = default;
            CompletionsLogProbabilityModel logprobs = default;
            CompletionsFinishReason finishReason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("index"u8))
                {
                    index = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("content_filter_results"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    contentFilterResults = ContentFilterResults.DeserializeContentFilterResults(property.Value);
                    continue;
                }
                if (property.NameEquals("logprobs"u8))
                {
                    logprobs = CompletionsLogProbabilityModel.DeserializeCompletionsLogProbabilityModel(property.Value);
                    continue;
                }
                if (property.NameEquals("finish_reason"u8))
                {
                    finishReason = new CompletionsFinishReason(property.Value.GetString());
                    continue;
                }
            }
            return new Choice(text, index, contentFilterResults.Value, logprobs, finishReason);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static Choice FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeChoice(document.RootElement);
        }
    }
}
