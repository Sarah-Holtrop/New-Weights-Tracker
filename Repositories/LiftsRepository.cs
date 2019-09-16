using System.Collections.Generic;
using System.Data;
using Dapper;
using fitlog.Models;

namespace fitlog.Repositories
{
  public class LiftsRepository
  {
    private readonly IDbConnection _db;
    public LiftsRepository(IDbConnection db)
    {
      _db = db;
    }
    public IEnumerable<Lift> GetLifts()
    {
      return _db.Query<Lift>("SELECT * FROM lifts");
    }
    public Lift CreateLift(Lift lift)
    {
      var id = _db.ExecuteScalar<int>(@"
      INSERT INTO lifts (name)
      VALUES (@Name);
      SELECT LAST_INSERT_ID();", lift);
      lift.Id = id;
      return lift;
    }
  }

}