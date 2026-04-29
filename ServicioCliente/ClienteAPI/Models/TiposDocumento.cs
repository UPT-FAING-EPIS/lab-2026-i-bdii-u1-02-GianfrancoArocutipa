using System;
using System.Collections.Generic;

namespace ClienteAPI.Models;

public partial class TiposDocumento
{
    public int IdTipoDocumento { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<ClientesDocumento> ClientesDocumentos { get; set; } = new List<ClientesDocumento>();
}
