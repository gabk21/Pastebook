using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PasteBook.Data.Models
{
    public partial class UserAccount : BaseEntity
    {
        public UserAccount()
        {
            BlockedAccounts = new HashSet<BlockedAccount>();
            FriendRequests = new HashSet<FriendRequest>();
            Friends = new HashSet<Friend>();
            Notifications = new HashSet<Notification>();
            Posts = new HashSet<Post>();
        }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [MinLength(1, ErrorMessage = "First name cannot be blank")]
        [MaxLength(50, ErrorMessage = "First name cannot not exceed 50 characters")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [MinLength(1, ErrorMessage = "Last name cannot be blank")]
        [MaxLength(50, ErrorMessage = "Last name cannot not exceed 50 characters")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Column(TypeName = "nvarchar(30)")]
        [MinLength(1, ErrorMessage = "Password cannot be blank")]
        [MaxLength(30, ErrorMessage = "Password cannot not exceed 30 characters")]
        public string Password { get; set; }
        [Required]
        [Column(TypeName = "datetime")]
        public DateTime Birthday { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [MinLength(1)]
        [MaxLength(10)]
        public string Gender { get; set; }
        public string? MobileNumber { get; set; }
        public bool Active { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "datetime")]
        public DateTime AccountCreated { get; set; }

        [InverseProperty(nameof(BlockedAccount.UserAccount))]
        public virtual ICollection<BlockedAccount> BlockedAccounts { get; set; }
        [InverseProperty(nameof(FriendRequest.RequestReceiver))]
        public virtual ICollection<FriendRequest> FriendRequests { get; set; }
        [InverseProperty(nameof(Friend.UserAccount))]
        public virtual ICollection<Friend> Friends { get; set; }
        [InverseProperty(nameof(Notification.UserAccount))]
        public virtual ICollection<Notification> Notifications { get; set; }
        [InverseProperty(nameof(Post.UserAccount))]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
