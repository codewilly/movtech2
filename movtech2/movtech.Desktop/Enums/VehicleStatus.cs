using System;
using System.Collections.Generic;
using System.Text;

namespace movtech.Desktop.Enums
{
    public enum VehicleStatus
    {
        Disponivel, // Disponível para ser alocado

        Alocado, // Alocado em um motorista

        Manutencao, // Parado em manutenção

        Sinistro, // Encontra-se em sinistro

        RemovidoFrota, // Não faz mais parte da frota

        Outro = 99


    }
}
