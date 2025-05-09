using System;
using System.ComponentModel.DataAnnotations;

namespace ADHDStudyApp.Models
{
    public class UserFile
    {
        public int Id { get; set; }

        public string? FileName { get; set; }

        public string? FilePath { get; set; }

        public DateTime UploadDate { get; set; } = DateTime.Now;

        // Foreign Key
        public int UserId { get; set; }

        // Navigation Property
        public User User { get; set; }
    }

}