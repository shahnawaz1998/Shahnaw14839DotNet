using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstApp2
{
	[Table("Book")]
	public class Book
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int BookID { get; set; }

		[Column(TypeName ="varchar(20)")]
		public string BookName { get; set; }

		[ForeignKey("PublisherID")]
		public Publisher Publisher { get; set; }

		
	}
}
