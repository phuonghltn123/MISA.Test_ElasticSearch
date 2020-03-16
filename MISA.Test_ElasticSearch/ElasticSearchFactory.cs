using Elasticsearch.Net;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Test_ElasticSearch
{
    public class ElasticSearchFactory
    {
        public ElasticClient ElasticSearchClient()
        {
            var node = new Uri[]
            {
                new Uri("https://localhost:9200/"),
            };
            var connectionPool = new StaticConnectionPool(node);
            var connectionSettings = new ConnectionSettings(connectionPool).DisableDirectStreaming();
            var elesticClient = new ElasticClient(connectionSettings);

            return elesticClient;
        }
    }
}
