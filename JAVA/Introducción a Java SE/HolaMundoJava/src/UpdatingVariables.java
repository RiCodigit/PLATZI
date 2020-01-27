public class UpdatingVariables {
    public static void main(String[] args) {
        int salary = 1000;

        //bono $300
        salary += 300;

        System.out.println(salary);

        //gastos: $50 descuento
        salary -= 50;

        System.out.println(salary);

        //realiza 2 horas extra(h.ext)| 1h.ext = 50$
        //comida: $40

        salary += (2*50)-40;
        System.out.println(salary);

        //Actualizando Strings
        String empleadoName = "R";

        empleadoName += " L";

        System.out.println(empleadoName);

        empleadoName =  "J" + empleadoName;

        System.out.println(empleadoName);

    }
}
