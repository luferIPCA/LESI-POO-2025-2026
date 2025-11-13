


namespace Aula_5___Heranca
{
    /// <summary>
    /// 
    /// 
    /// </summary>
    public interface IVeiculo :  IPago
    {
        //int ano;      //em interfaces não pode existe atributos!!!
        int QuantosKms(int litros);
    }
}
