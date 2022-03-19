using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace Models.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }

        [StringLength(100)]
        [Required]
        public string nombre { get; set; }


        [StringLength(100)]
        [Required]
        public string email { get; set; }

        [StringLength(100)]
        [Required]
        public string password { get; set; }

        public class Mapeo
        {
            public Mapeo(EntityTypeBuilder<User> mapeoUser)
            {
                mapeoUser.HasKey(x => x.userId);
                mapeoUser.Property(x => x.nombre).HasColumnName("nombre");
                mapeoUser.Property(x => x.email).HasColumnName("email");
                mapeoUser.Property(x => x.password).HasColumnName("password");
                mapeoUser.ToTable("users");
                //mapeoAutor.HasOne(x => x.Autor);
            }
        }
    }
}
