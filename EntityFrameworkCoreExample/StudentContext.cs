﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCoreExample
{
	// EF Core Getting started
	// https://docs.microsoft.com/en-us/ef/core/get-started/overview/install
	public class StudentContext: DbContext
	{
		public StudentContext()
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			// Database = The desired name for the database
			// Server = The server we are connecting to. LocalDB is included with VS
			// Trusted_Connection - indicates that our windows account should be used
			options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExample;Trusted_Connection=True;");
		}
	}
}