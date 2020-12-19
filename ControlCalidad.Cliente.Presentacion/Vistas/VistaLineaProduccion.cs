using ControlCalidad.Cliente.AccesoExterno.ControlCalidadServiceReference;
using ControlCalidad.Cliente.Presentacion.Interfaces;
using ControlCalidad.Cliente.Presentacion.Presentadores;
using ControlCalidad.Cliente.Presentacion.Vistas.ControladoresDeUsuario.Pantalla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlCalidad.Cliente.Presentacion.Vistas
{
    public partial class VistaLineaProduccion : FormBase, IVistaLineaProduccion
    {
        private List<IzquierdaDerechaPorHora> _pHorasHead = new List<IzquierdaDerechaPorHora>();
        private List<IzquierdaDerechaPorHora> _pHorasParesHead = new List<IzquierdaDerechaPorHora>();
        private List<DefectoIzqDerHora> _pContadores = new List<DefectoIzqDerHora>();
        private List<DefectoIzqDerHora> _pContadorespares = new List<DefectoIzqDerHora>();
        private List<DefectoCelda> _pDefectoId = new List<DefectoCelda>();
        private List<DefectoCelda> _pDefectoTipo = new List<DefectoCelda>();
        private List<DefectoCelda> _pDefectoAcumulado = new List<DefectoCelda>();
        private OpDto _opActual;
        public TurnoDto _turno { get; set; }
        public VistaLineaProduccion()
        {
            InitializeComponent();
            defectoTipoHead.SetTexto("Tipo");
        }

        public void ActualizarDatosDeOPActual(OpDto opActual)
        {
            _opActual = opActual;
            tbNroOpAct.Text = _opActual.Numero.ToString();
            tbFecOpAct.Text = _opActual.FechaInicio.ToString("dd/MM/yyyy");
            tbLineaOpAct.Text = _opActual.Linea.Numero.ToString();
            tbModeloOpAct.Text = _opActual.Modelo.Denominacion;
            tbObjetivoOpAct.Text = _opActual.Modelo.Objetivo.ToString();
            tbEmpleado.Text = _opActual.Empleado.Nombre;

        }

        public void ActualizarTurno(TurnoDto turno)
        {
            _turno = turno;
            int i = 0;
            foreach (var h in turno.Horas)
            {
                IzquierdaDerechaPorHora izqDerPorHora = new IzquierdaDerechaPorHora();
                izqDerPorHora.SetHora(h);
                izqDerPorHora.Location = new Point(izquierdaDerechaPorHora.Location.X + izquierdaDerechaPorHora.Size.Width * i, izquierdaDerechaPorHora.Location.Y);

                pDefectos.Controls.Add(izqDerPorHora);
                _pHorasHead.Add(izqDerPorHora);
                i++;
            }
            DefectoCelda AcumuladoHead = new DefectoCelda();
            AcumuladoHead.SetTexto("Acumulado");
            AcumuladoHead.Location = new Point(izquierdaDerechaPorHora.Location.X + izquierdaDerechaPorHora.Size.Width * i, izquierdaDerechaPorHora.Location.Y);
            pDefectos.Controls.Add(AcumuladoHead);
            
            // cargar primera

            var sumatoria = 0.0;
            var cantidadHoras = turno.Horas.Length;
            i = 0;
            foreach (var h in turno.Horas)
            {
                var tupla = CargarContadoresPares(h);

                
                DefectoIzqDerHora contador = new DefectoIzqDerHora();
                contador.SetContadores(tupla.Item2, tupla.Item1);
                sumatoria += tupla.Item2;
                contador.Location = new Point(RelacionObjetivoPrimera.Location.X + RelacionObjetivoPrimera.Size.Width * i, RelacionObjetivoPrimera.Location.Y );
                pPares.Controls.Add(contador);
                _pContadorespares.Add(contador);


                IzquierdaDerechaPorHora izqDerPorHora = new IzquierdaDerechaPorHora();
                izqDerPorHora.SetHora(h);
                izqDerPorHora.CambiarCabecera();
                izqDerPorHora.Location = new Point(PrimeraObjetivoHora.Location.X + PrimeraObjetivoHora.Size.Width * i, PrimeraObjetivoHora.Location.Y);

                pPares.Controls.Add(izqDerPorHora);
                _pHorasParesHead.Add(izqDerPorHora);
                i++;
            }
            Promedio.SetTexto(string.Format("{0:0.00}",(sumatoria / cantidadHoras)));
        }

        public void CargarEspecificaciones(EspecificacionDeDefectoDto[] especificaciones)
        {
            var horas = _turno.Horas;
            var i = 0;
            var j = 0;
            foreach (var especificacion in especificaciones)
            {
                DefectoCelda defectoId = new DefectoCelda();
                DefectoCelda defectoTipo = new DefectoCelda();
                defectoId.SetTexto(especificacion.Id.ToString());
                defectoTipo.SetTexto(especificacion.TipoDefecto);
                defectoId.Location = new Point(DefectoId.Location.X , DefectoId.Location.Y + DefectoId.Size.Height * i);
                defectoTipo.Location = new Point(DefectoTipo.Location.X , DefectoTipo.Location.Y + DefectoTipo.Size.Height * i);
                pDefectos.Controls.Add(defectoId);
                pDefectos.Controls.Add(defectoTipo);
                _pDefectoId.Add(defectoId);
                _pDefectoTipo.Add(defectoTipo);

                DefectoIzqDerHora contadorAcumulado = new DefectoIzqDerHora();

                foreach (var hora in horas)
                {
                    var tupla = CargarContadoresDefecto(especificacion.Id, hora);
                    contadorAcumulado.acumuladoDer += tupla.Item1;
                    contadorAcumulado.acumuladoIzq += tupla.Item2;
                    DefectoIzqDerHora contador = new DefectoIzqDerHora();
                    contador.SetContadores(tupla.Item1, tupla.Item2);
                    contador.Location = new Point(DefectoIzqDerHora.Location.X + DefectoIzqDerHora.Size.Width * j, DefectoIzqDerHora.Location.Y + DefectoIzqDerHora.Size.Height * i);

                    pDefectos.Controls.Add(contador);
                    _pContadores.Add(contador);
                    j++;
                }
               
                contadorAcumulado.SetContadores();
                contadorAcumulado.Location = new Point(DefectoIzqDerHora.Location.X + DefectoIzqDerHora.Size.Width * j, DefectoIzqDerHora.Location.Y + DefectoIzqDerHora.Size.Height * i);
                pDefectos.Controls.Add(contadorAcumulado);
                j = 0;

                i++;
            }



        }

        public void Desplegar()
        {
            Show();
        }

        private void Vista_MouseUp(object sender, MouseEventArgs e)
        {
            mouseUp(sender, e);
        }

        private void Vista_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown(sender, e);
        }

        private void Vista_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove(sender, e);
        }


        private (int, int) CargarContadoresDefecto(int id,string hora)
        {
            var horario = _opActual.Horarios.LastOrDefault();
            var Hora = TimeSpan.Parse(hora);



            if (horario != null)
            {
                var horamas1 = Hora.Add(TimeSpan.Parse("01:00"));
                if (Hora <= horamas1)
                {
                    var contadorderecho = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Derecho"
                                && (e.Hora.TimeOfDay >= Hora && e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    var contadorizquierdo = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Izquierdo"
                                && (e.Hora.TimeOfDay >= Hora && e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    return (contadorderecho, contadorizquierdo);
                }
                else
                {
                    var contadorderecho = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Derecho"
                                && (e.Hora.TimeOfDay >= Hora || e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    var contadorizquierdo = horario.Defectos.Where(e => e.EspecificacionDeDefecto.Id == id && e.Pie == "Izquierdo"
                                && (e.Hora.TimeOfDay >= Hora || e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    return (contadorderecho, contadorizquierdo);
                }

            }
            return (0, 0);
        }

        private (int, int) CargarContadoresPares(string hora)
        {
            var horario = _opActual.Horarios.LastOrDefault();
            var Hora = TimeSpan.Parse(hora);



            if (horario != null)
            {
                var horamas1 = Hora.Add(TimeSpan.Parse("01:00"));
                if (Hora <= horamas1)
                {
                    var contadorizquierdo = horario.Pares.Where(e => e.calidad == "Primera"   && (e.Hora.TimeOfDay >= Hora && e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    var contadorderecho = _opActual.Modelo.Objetivo;
                    return (contadorderecho, contadorizquierdo);
                }
                else
                {
                    var contadorizquierdo = horario.Pares.Where(e => e.calidad == "Primera" || (e.Hora.TimeOfDay >= Hora && e.Hora.TimeOfDay < Hora.Add(TimeSpan.Parse("01:00")))).Count();
                    var contadorderecho = _opActual.Modelo.Objetivo;
                    return (contadorderecho, contadorizquierdo);
                }

            }
            return (0, 0);
        }

    }
}
