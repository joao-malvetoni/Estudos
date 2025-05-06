﻿using AppTask.Models;
using Microsoft.EntityFrameworkCore;

namespace AppTask.Database
{
	public class AppTaskContext : DbContext
	{
		public DbSet<TaskModel> Tasks { get; set; }
		public DbSet<SubTaskModel> SubTasks { get; set; }
		public AppTaskContext()
		{
			//Database.Migrate();
			ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);

			var folderPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
			var databaseName = "apptask.db";

			var databasePath = Path.Combine(folderPath, databaseName);

			optionsBuilder.UseSqlite($"Filename={databasePath}");
		}
	}
}
