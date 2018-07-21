
using BenchmarkDotNet.Attributes;
using System.Linq;
using RepoDb;
using System.Data.SqlClient;

namespace Dapper.Tests.Performance
{
    public class RepoDbBenchmarks : BenchmarkBase
    {
        private DbRepository<SqlConnection> _repository;

        [GlobalSetup]
        public void Setup()
        {
            BaseSetup();
            _repository = new DbRepository<SqlConnection>(ConnectionString);
        }

        [Benchmark(Description = "Query<T> (unbuffered)")]
        public Post QueryUnbuffered()
        {
            Step();
            return _repository.Query<Post>(new { Id = i }).First();
        }

        [Benchmark(Description = "QueryFirstOrDefault<T>")]
        public Post QueryFirstOrDefault()
        {
            Step();
            return _repository.Query<Post>(new { Id = i }).FirstOrDefault();
        }
    }
}
