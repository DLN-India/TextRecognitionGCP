namespace QuickType
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Welcome
    {
        [JsonProperty("inputConfig")]
        public InputConfig InputConfig { get; set; }

        [JsonProperty("responses")]
        public Response[] Responses { get; set; }
    }

    public partial class InputConfig
    {
        [JsonProperty("gcsSource")]
        public GcsSource GcsSource { get; set; }

        [JsonProperty("mimeType")]
        public string MimeType { get; set; }
    }

    public partial class GcsSource
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public partial class Response
    {
        [JsonProperty("fullTextAnnotation")]
        public FullTextAnnotation FullTextAnnotation { get; set; }

        [JsonProperty("context")]
        public Context Context { get; set; }
    }

    public partial class Context
    {
        [JsonProperty("uri")]
        public string Uri { get; set; }

        [JsonProperty("pageNumber")]
        public long PageNumber { get; set; }
    }

    public partial class FullTextAnnotation
    {
        [JsonProperty("pages")]
        public Page[] Pages { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class Page
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("blocks")]
        public Block[] Blocks { get; set; }

        [JsonProperty("confidence")]
        public long Confidence { get; set; }
    }

    public partial class Block
    {
        [JsonProperty("boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [JsonProperty("paragraphs")]
        public Paragraph[] Paragraphs { get; set; }

        [JsonProperty("blockType")]
        public string BlockType { get; set; }

        [JsonProperty("confidence")]
        public long Confidence { get; set; }
    }

    public partial class BoundingBox
    {
        [JsonProperty("normalizedVertices")]
        public NormalizedVertex[] NormalizedVertices { get; set; }
    }

    public partial class NormalizedVertex
    {
        [JsonProperty("x")]
        public double X { get; set; }

        [JsonProperty("y")]
        public double Y { get; set; }
    }

    public partial class Paragraph
    {
        [JsonProperty("boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [JsonProperty("words")]
        public Word[] Words { get; set; }

        [JsonProperty("confidence")]
        public long Confidence { get; set; }
    }

    public partial class Word
    {
        [JsonProperty("boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [JsonProperty("symbols")]
        public Symbol[] Symbols { get; set; }

        [JsonProperty("confidence")]
        public long Confidence { get; set; }
    }

    public partial class Symbol
    {
        [JsonProperty("boundingBox")]
        public BoundingBox BoundingBox { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("confidence")]
        public long Confidence { get; set; }

        [JsonProperty("property", NullValueHandling = NullValueHandling.Ignore)]
        public Property Property { get; set; }
    }

    public partial class Property
    {
        [JsonProperty("detectedBreak")]
        public DetectedBreak DetectedBreak { get; set; }
    }

    public partial class DetectedBreak
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
