using System.Collections.Generic;
using System.Data;
using Dapper;
using fitlog.Models;

namespace fitlog.Repositories
{
  public class WeightsRepository
  {
    private readonly IDbConnection _db;
    public WeightsRepository(IDbConnection db)
    {
      _db = db;
    }
    public Weight AddWeight(Weight weight)
    {
      var id = _db.ExecuteScalar<int>(@"
      INSERT INTO weights (amount)
      VALUES (@Amount);
      SELECT LAST_INSERT_ID();", weight);
      weight.Id = id;
      return weight;
    }
    public IEnumerable<Weight> GetWeightsByLiftId()
  }
}