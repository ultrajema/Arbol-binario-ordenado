

/**
 *
 * @author Carr
 */
public class Estudiante : Comparador { //implementamos nuestra interfaz la cual nos dara automaticamente nuestros metodos

    //PROPIEDADES 
    public string descripcion;
    public string nombre; //Nombre

    public bool igualQue(object q)
    {
        //throw new System.NotImplementedException();
        return true;
    }
    public bool mayorQue(object q)
    {

        Estudiante p2 = (Estudiante)q;
        //utilizamos compareTo >0 ya que estas seran las letras que estaran mas cerca de la z  
        return nombre.CompareTo(p2.nombre) > 0;//comparamos el nombre con el nombre que esta recorriendo el objeto 

    }
    public bool menorQue(object op2)
    {
        Estudiante p2 = (Estudiante)op2;
        //ahora utilizando compareTo <0 porque ahora seran las letras que estaran mas cercanas a la a
        return nombre.CompareTo(p2.nombre) < 0;
    }
    public bool mayorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) >= 0;

    }
    public bool menorIgualQue(object q)
    {
        Estudiante p2 = (Estudiante)q;
        return nombre.CompareTo(p2.nombre) <= 0;

    }




}