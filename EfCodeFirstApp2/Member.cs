using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCodeFirstApp2
{
	[Table("Member")]
	public class Member
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.None)]
		public int MemberID { get; set; }

		[Column(TypeName ="varchar(20)")]
		public string MemberName { get; set; }

		
	}
}
