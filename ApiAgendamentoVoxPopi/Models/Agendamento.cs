namespace ApiAgendamentoVoxPopi.Models
{
    public class Medico
    {
        public int IdMedico { get; set; }
        public int IdEspecialidade { get; set; }

        public ICollection<MedicoHorarioDia> MedicoHorariosDias { get; set; } = new List<MedicoHorarioDia>();
        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }

    public class Horario
    {
        public int IdHorario { get; set; } 

        public ICollection<MedicoHorarioDia> MedicoHorariosDias { get; set; } = new List<MedicoHorarioDia>();
        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }

    public class DiaSemana
    {
        public int IdDia { get; set; }
        public string Dia { get; set; } 

        public ICollection<MedicoHorarioDia> MedicoHorariosDias { get; set; } = new List<MedicoHorarioDia>();
        public ICollection<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }

    public class MedicoHorarioDia
    {
        public int IdMedico { get; set; }
        public Medico Medico { get; set; }

        public int IdHorario { get; set; }
        public Horario Horario { get; set; }

        public int IdDia { get; set; }
        public DiaSemana DiaSemana { get; set; }
    }


    public class Agendamento
    {
        public Guid IdAgendamento { get; set; }
        public int IdMedico { get; set; }
        public Medico Medico { get; set; }

        public int IdHorario { get; set; }
        public Horario Horario { get; set; }

        public int IdDia { get; set; }
        public DiaSemana DiaSemana { get; set; }

        public DateTime DtAgendamento { get; set; }
    }
}
