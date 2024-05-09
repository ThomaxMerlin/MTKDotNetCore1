using MTKDotNetCore.ConsoleApp;
using MTKDotNetCore.ConsoleApp.AdoDotNetExamples;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

// npm
// pub.dev
// nuget
// SqlConnection

// Ctrl + . => suggestion
// F10 => 
// F11
// F9 => breakpoint

// => C# => Db

//SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
//stringBuilder.DataSource = "DESKTOP-4LL7LAJ"; //server name 
//stringBuilder.InitialCatalog = "DotNetTrainingBatch4"; //database name
//stringBuilder.UserID = "sa";
//stringBuilder.Password = "sa@123";
//SqlConnection connection = new SqlConnection(stringBuilder.ConnectionString);
//SqlConnection connection = new SqlConnection("Data Source=DESKTOP-4LL7LAJ;Initial Catalog=DotNetTrainingBatch4;User ID=sa;Password=sa@123");

//connection.Open();
//Console.WriteLine("Connection open.");

//string query = "select * from tbl_blog\r\n ";
//SqlCommand cmd = new SqlCommand(query, connection); 
//SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
//DataTable dt = new DataTable();
//sqlDataAdapter.Fill(dt);



//connection.Close();
//Console.WriteLine("Connection close.");

// dataset => datatable
// datatable => datarow
// datarow => datacolumn

//foreach (DataRow dr in dt.Rows)
//{
// Console.WriteLine("Blog Id =>" + dr["BlogId"]);
// Console.WriteLine("Blog Title =>" + dr["BlogTitle"]);
//Console.WriteLine("Blog Author =>" + dr["BlogAuthor"]);
//  Console.WriteLine("Blog Content =>" + dr["BlogContent"]);
//Console.WriteLine("--------------------------------");
//}

//Console.ReadKey();

//AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.Read();
//adoDotNetExample.Create("title", "author", "content");
//adoDotNetExample.Update(1002, "title 1", "author 1 ", "content 1");
//adoDotNetExample.Delete(1002);
//adoDotNetExample.Edit(1002);
//adoDotNetExample.Edit(1);

AdoDotNetExample

Console.ReadLine();