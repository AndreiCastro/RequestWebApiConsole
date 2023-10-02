namespace RequestWebApi
{
    public  class DeserializeJson
    {
        public int Page { get; set; }
        public int Per_Page { get; set; }
        public int Total { get; set; }
        public int Total_Pages { get; set; }
        public IList<DataDeserializeJson> Data { get; set; }
    }
}
