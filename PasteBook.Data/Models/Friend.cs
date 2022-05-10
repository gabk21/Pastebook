using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PasteBook.Data.Models
{
    public partial class Friend
    {
        [Key]
        public int Id { get; set; }
        public int UserAccountId { get; set; }
        public int FriendAccountId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column(TypeName = "datetime")]
        public DateTime TimeStamp { get; set; }

        [ForeignKey(nameof(UserAccountId))]
        [InverseProperty("Friends")]
        public virtual UserAccount UserAccount { get; set; }
    }
}
