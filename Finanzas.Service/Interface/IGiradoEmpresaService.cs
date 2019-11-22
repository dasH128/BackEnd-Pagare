using Finanzas.Entity;

namespace Finanzas.Service.Interface
{
    public interface IGiradoEmpresaService: ICrudService<GiradoEmpresa>
    {
         GiradoEmpresa GiradoData(GiradoEmpresa giradoEmpresa);
    }
}