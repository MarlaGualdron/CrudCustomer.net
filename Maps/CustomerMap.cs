using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using  CrudCustomers.Api.Models;

namespace CrudCustomers.Api.Maps;

	public class CustomerMap
{
		public CustomerMap(EntityTypeBuilder<Customer> entityBuilder)

	{
		entityBuilder.HasKey(x => x.Id);
		entityBuilder.ToTable("customers");

		entityBuilder.Property(x => x.Id).HasColumnName("id");
		entityBuilder.Property(x => x.Full_name).HasColumnName("full_name");
		entityBuilder.Property(x => x.Date_of_birth).HasColumnName("date_of_birth");
		entityBuilder.Property(x => x.Gender).HasColumnName("gender");
		entityBuilder.Property(x => x.Cuil).HasColumnName("cuil");
		entityBuilder.Property(x => x.Phone).HasColumnName("phone");
		entityBuilder.Property(x => x.Deleted).HasColumnName("deleted");

	 }
		
}
