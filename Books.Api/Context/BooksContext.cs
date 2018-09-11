using System;
using Books.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Books.Api.Context
{
    public class BooksContext: DbContext
    {
        public DbSet<Book> Books { get; set; }

        public BooksContext(DbContextOptions<BooksContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author()
                {
                    Id = Guid.Parse("8d7379bb-be72-4acc-8a2f-f04b01fe6339"),
                    FirstName = "George",
                    LastName = "RR Martin"
                },
                new Author()
                {
                    Id = Guid.Parse("eadd5fde-968b-4e5e-b169-15edc4943b4e"),
                    FirstName = "Stephen",
                    LastName = "Fry"
                },
                new Author()
                {
                    Id = Guid.Parse("5b9d3258-a26b-4b65-a3e0-fbb1eeb0be3f"),
                    FirstName = "Jemes",
                    LastName = "Elroy"
                },
                new Author()
                {
                    Id = Guid.Parse("16c75331-90e4-4f55-8446-5bf309242604"),
                    FirstName = "Douglas",
                    LastName = "Adams"
                }
            );
            
            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = Guid.Parse("3fb66003-f81d-424a-9105-ea7dbb498478"),
                    AuthorId = Guid.Parse("8d7379bb-be72-4acc-8a2f-f04b01fe6339"),
                    Title = "The Winds of Winter",
                    Description = "The book that seems impossible to write."
                },
                new Book()
                {
                    Id = Guid.Parse("48ac625e-d8e7-4f0a-87dc-8ec1a7f289f8"),
                    AuthorId = Guid.Parse("8d7379bb-be72-4acc-8a2f-f04b01fe6339"),
                    Title = "A Game of Thrones",
                    Description = "A Game of Thrones is the first novel in a Songs of Ice and Fire"
                },
                new Book()
                {
                    Id = Guid.Parse("5e77b630-01e8-473c-83b1-d2d7ed7535a2"),
                    AuthorId = Guid.Parse("5b9d3258-a26b-4b65-a3e0-fbb1eeb0be3f"),
                    Title = "Mythos",
                    Description = "The Greek myths are amongst the best stories ever told..."
                },
                new Book()
                {
                    Id = Guid.Parse("f136af59-ba99-4864-930a-3d62de9fed94"),
                    AuthorId = Guid.Parse("16c75331-90e4-4f55-8446-5bf309242604"),
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "In the Hitchhiker's Guide tot he Galaxy..."
                }
            );
            
            base.OnModelCreating(modelBuilder);
        }
    }
}