public class DataTypes {
    public static void main(String[] args) {

        int n = 1234567890; // limite del "integer"
        long nL = 12345678901L; // limite del "dato" long (poner L al final)

        // limite del dato "Float" , acepta numeros decimales  ( si no tiene decimales hay que poner F al final)
        float nF = 123456789012345678901234567890123456789F;

        // limite del dato "double" es muy grande y acepta numero decimales ( si no tiene decimales hay que poner D al final)
        double nD = 123456789012345678901234567890123456789123456789012345678901234567890012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789D;




        // Uso de tipos de datos con la palabra reservada "VAR" ( Se puede usar a partir del JDk 10 de JAVA)

        // APARTADO NUMEROS

        var salary = 1000; // int

        // pension del 3% // Double
        var pension = salary * 0.03;

        var totalSalary = salary - pension; // double

        System.out.println(salary);
        System.out.println(pension);
        System.out.println(totalSalary);

        // APARTADO CARACTERES Y LETRAS

        var employeeName = "Rick Londini";
        System.out.println("Empleado: " + employeeName + " Salario: " + totalSalary);




    }

}
