using Finanzas.Entity;

namespace Finanzas.Repository.Interface
{
    public interface IGiradoEmpresaRepository: ICrudRepository<GiradoEmpresa>
    {
        GiradoEmpresa GiradoData(GiradoEmpresa giradoEmpresa);
    }
}