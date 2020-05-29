using ClinicaMedica.Entidades;
using NUnit.Framework;

namespace ClinicaMedica.Test
{
    public class PacienteTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test, Category("Propriedades")]
        public void IDNãoPodeSerNulo()
        {
            Paciente p = new Paciente();

            Assert.IsNotNull(p.ID);

            Assert.Pass();
        }
    }
}