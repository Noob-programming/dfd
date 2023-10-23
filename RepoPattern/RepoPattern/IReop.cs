using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RepoPattern
{
	public class User
	{
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public DateTime BirthDate { get; set; }

		// Additional properties and methods can be added as needed.

		public User(int id, string firstName, string lastName, string email, DateTime birthDate)
		{
			Id = id;
			FirstName = firstName;
			LastName = lastName;
			Email = email;
			BirthDate = birthDate;
		}

		public override string ToString()
		{
			return $"{FirstName} {LastName} (ID: {Id})";
		}
	}

	public interface IRepository<T>
	{
		T GetById(int id);
		IEnumerable<T> GetAll();
		void Add(T entity);
		void Update(T entity);
		void Delete(int id);
	}
	public class UserRepository : IRepository<User>
	{
		private readonly string connectionString;

		public UserRepository(string connectionString)
		{
			this.connectionString = connectionString;
		}

		public User GetById(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// Use ADO.NET to retrieve the entity by its ID and return it.
				// You may want to use SqlCommand and SqlDataReader for this.
				// Example:
				// var command = new SqlCommand("SELECT * FROM Users WHERE Id = @Id", connection);
				// command.Parameters.AddWithValue("@Id", id);
				// using (var reader = command.ExecuteReader())
				// {
				//     if (reader.Read())
				//     {
				//         // Create and return a User object
				//     }
				//     return null;
				// }
				return null;
			}
		}

		public IEnumerable<User> GetAll()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// Use ADO.NET to retrieve all entities and return them as a list.
				// Example:
				// var command = new SqlCommand("SELECT * FROM Users", connection);
				// using (var reader = command.ExecuteReader())
				// {
				//     while (reader.Read())
				//     {
				//         // Create User objects and add them to a list
				//     }
				// }
				// return userList;
			}

			return null;
		}

		public void Add(User entity)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// Use ADO.NET to insert the entity into the database.
				// Example:
				// var command = new SqlCommand("INSERT INTO Users (Name, Email) VALUES (@Name, @Email)", connection);
				// command.Parameters.AddWithValue("@Name", entity.Name);
				// command.Parameters.AddWithValue("@Email", entity.Email);
				// command.ExecuteNonQuery();
			}
		}

		public void Update(User entity)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// Use ADO.NET to update the entity in the database.
				// Example:
				// var command = new SqlCommand("UPDATE Users SET Name = @Name, Email = @Email WHERE Id = @Id", connection);
				// command.Parameters.AddWithValue("@Name", entity.Name);
				// command.Parameters.AddWithValue("@Email", entity.Email);
				// command.Parameters.AddWithValue("@Id", entity.Id);
				// command.ExecuteNonQuery();
			}
		}

		public void Delete(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				// Use ADO.NET to delete the entity from the database by its ID.
				// Example:
				// var command = new SqlCommand("DELETE FROM Users WHERE Id = @Id", connection);
				// command.Parameters.AddWithValue("@Id", id);
				// command.ExecuteNonQuery();
			}
		}
	}

}