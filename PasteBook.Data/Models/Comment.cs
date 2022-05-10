using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PasteBook.Data.Models
{
    public partial class Comment : BaseEntity
    {
        public Comment()
        {
            Notifications = new HashSet<Notification>();
        }
        public int PostId { get; set; }
        public int CommentingUserId { get; set; }
        [Column("Comment")]
        public string Comment1 { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("Comments")]
        public virtual Post Post { get; set; }
        [InverseProperty(nameof(Notification.Comment))]
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
