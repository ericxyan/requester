namespace Requester
{
    public class ContentTypes
    {
        public static ContentTypes Instance { get; private set; }

        public string ApplicationJavaScript { get { return "application/javascript"; } }
        public string ApplicationJson { get { return "application/json"; } }
        public string ApplicationJsonLd { get { return "application/ld+json"; } }
        public string ApplicationGeoJson { get { return "application/vnd.geo+json"; } }
        public string TextJson { get { return "text/json"; } }

        static ContentTypes()
        {
            Instance = new ContentTypes();
        }

        private ContentTypes() { }
    }
}