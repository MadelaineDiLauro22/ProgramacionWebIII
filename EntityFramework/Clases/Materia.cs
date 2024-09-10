﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Clases
{
    public class Materia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string Nombre { get; set; }
        public float CargaHoraria { get; set; }
        public string Comisiones { get; set; }

        public virtual ICollection<ReporteAlumno> Reportes { get; set; }
    }
}
