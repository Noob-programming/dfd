﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using testDG.Properties;

namespace testDG.Logic.Services
{
	internal static class DbHelper
	{
		public static SqlCommand Command { get; private set; }

		private static SqlConnection GetConnection()
		{
			try
			{
				var builder = new SqlConnectionStringBuilder
				{
					DataSource = Settings.Default.ServerName,
					InitialCatalog = Settings.Default.DataBase,
					IntegratedSecurity = Settings.Default.IntegratedSecurity
				};
				/*
				builder.DataSource = Properties.Settings.Default.ServerName,
				builder.InitialCatalog = Properties.Settings.Default.DataBase,
				builder.IntegratedSecurity = Properties.Settings.Default.IntegratedSecurity
				 */

				return new SqlConnection(builder.ConnectionString);
			}
			catch (Exception exception)
			{
				MessageBox.Show($@"{exception}");
			}

			return null;
		}

		public static bool ExecuteData(string spName, Action action)
		{
			using (var connection = GetConnection())
			{
				try
				{
					Command = new SqlCommand(spName, connection);
					Command.CommandType = CommandType.StoredProcedure;
					//execute method that contain parameter
					action.Invoke();
					connection.Open();
					Command.ExecuteNonQuery();
					connection.Close();
					return true;
				}
				catch (Exception e)
				{
					MessageBox.Show($@"{e}");
					return false;
				}
				finally
				{
					connection.Close();
				}

			}
		}
	}
}