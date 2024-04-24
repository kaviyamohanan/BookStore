using Microsoft.Data.SqlClient;

namespace FinalProjectShoppingCart.Data
{
    public class BookDataSeeder
    {
        public static void SeedData()
        {
            string connectionString = "your_connection_string_here"; // Replace with your actual connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Seed Genre table
                string genreSql = @"
                    SET IDENTITY_INSERT [dbo].[Genre] ON
                    INSERT INTO [dbo].[Genre] ([Id], [GenreName]) VALUES (1, N'Romance')
                    INSERT INTO [dbo].[Genre] ([Id], [GenreName]) VALUES (2, N'Action')
                    INSERT INTO [dbo].[Genre] ([Id], [GenreName]) VALUES (3, N'Thriller')
                    INSERT INTO [dbo].[Genre] ([Id], [GenreName]) VALUES (4, N'Crime')
                    INSERT INTO [dbo].[Genre] ([Id], [GenreName]) VALUES (5, N'SelfHelp')
                    INSERT INTO [dbo].[Genre] ([Id], [GenreName]) VALUES (6, N'Programming')
                    SET IDENTITY_INSERT [dbo].[Genre] OFF";

                SqlCommand genreCommand = new SqlCommand(genreSql, connection);
                genreCommand.ExecuteNonQuery();

                // Seed Books table
                string booksSql = @"
                    SET IDENTITY_INSERT [dbo].[Books] ON
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (1, N'Pride and Prejudice', N'Jane Austen', 12.99, N'pride-and-prejudice.jpg', 1)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (2, N'The Notebook', N'Nicholas Sparks', 11.99, N'TheNotebook.jpg', 1)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (3, N'Outlander', N'Diana Gabaldon', 14.99, N'Outlander.jpg', 1)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (4, N'Me Before You', N'Jojo Moyes', 10.99, N'Me_Before_You.jpg', 1)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (5, N'The Fault in Our Stars', N'John Green', 9.99, N'the_fault.jpg', 1)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (6, N'The Bourne Identity', N'Robert Ludlum', 14.99, N'Identity.jpg', 2)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (7, N'Die Hard', N'Roderick Thorp', 13.99, N'Diehard.jpg', 2)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (8, N'Jurassic Park', N'Michael Crichton', 15.99, NULL, 2)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (9, N'The Da Vinci Code', N'Dan Brown', 12.99, NULL, 2)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (10, N'The Hunger Games', N'Suzanne Collins', 11.99, NULL, 2)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (11, N'Gone Girl', N'Gillian Flynn', 11.99, NULL, 3)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (12, N'The Girl with the Dragon Tattoo', N'Stieg Larsson', 10.99, NULL, 3)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (13, N'The Silence of the Lambs', N'Thomas Harris', 12.99, NULL, 3)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (14, N'Before I Go to Sleep', N'S.J. Watson', 9.99, NULL, 3)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId]) VALUES (15, N'The Girl on the Train', N'Paula Hawkins', 13.99, NULL, 3)
                    INSERT INTO [dbo].[Books] ([Id], [BookName], [AuthorName], [Price], [Image], [GenreId



                    SET IDENTITY_INSERT [dbo].[Books] OFF";

                SqlCommand booksCommand = new SqlCommand(booksSql, connection);
                booksCommand.ExecuteNonQuery();
            }
        }
    }
}
