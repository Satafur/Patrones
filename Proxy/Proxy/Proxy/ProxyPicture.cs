﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class ProxyPicture : IPicturAble
{
    private RealPicture oRealPicture = null;
    private string nombre;
    

    public ProxyPicture(string nombre)
    {
        this.nombre = nombre;
    }
    

	public void MostrarImagen()
	{
        if (oRealPicture == null)
        {
            oRealPicture = new RealPicture(nombre);
        }
        oRealPicture.MostrarImagen();
    }

}
