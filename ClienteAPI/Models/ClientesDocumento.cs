using System;
using System.Collections.Generic;

namespace ClienteAPI.Models;

public partial class ClientesDocumento
{
    public int IdClienteDocumento { get; set; }

    public int? IdCliente { get; set; }

    public int? IdTipoDocumento { get; set; }

    public string NumeroDocumento { get; set; } = null!;

    public virtual Cliente? IdClienteNavigation { get; set; }

    public virtual TiposDocumento? IdTipoDocumentoNavigation { get; set; }
}
