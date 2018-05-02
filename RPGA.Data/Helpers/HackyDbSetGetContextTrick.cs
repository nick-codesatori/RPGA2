using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace RPGA.Data
{
	public static class HackyDbSetGetContextTrick
	{
		public static DbContext GetContext<TEntity>(this DbSet<TEntity> dbSet)
			 where TEntity : class
		{
			return (DbContext)dbSet
				 .GetType().GetTypeInfo()
				 .GetField("_context", BindingFlags.NonPublic | BindingFlags.Instance)
				 .GetValue(dbSet);
		}
	}
}