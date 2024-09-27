﻿using System;
using System.Collections.Generic;

public class EmpresaMadre : Empresa
{
    protected IList<Empresa> filiales =
      new List<Empresa>();

    public override bool AgregaFilial(Empresa filial)
    {
        filiales.Add(filial);
        return true;
    }

    public override double CalculaCosteMantenimiento()
    {
        double coste = 0.0;
        foreach (Empresa filial in filiales)
            coste = coste + filial.CalculaCosteMantenimiento();
        return coste + nVehiculos * costeUnitarioVehiculo;
    }
}