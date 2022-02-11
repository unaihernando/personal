package paquete;
import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;

import hiberclass.Departamentos;
import hiberclass.Empleados;

public class Main {
	
	public static void main(String[] args) {
		
		SessionFactory sesion = HibernateUtil.getSessionFactory();
		Session session = sesion.openSession();

		String hql = "from Departamentos where dnombre = 'CONTABILIDAD' or dnombre = 'INVESTIGACION'";
		Query q = session.createQuery(hql);
		
		System.out.println();
		System.out.println("Visualiza los datos del departamento Contabilidad e Investigación");
		System.out.println();
		
		for(int i = 0; i < q.list().size(); i++) {
			
			Departamentos dep = (Departamentos) q.list().get(i);
			System.out.println(dep.getDeptNo() + ", " + dep.getDnombre() + ", " + dep.getLoc());
				
		}
		
		hql = "from Empleados where departamentos.dnombre = 'CONTABILIDAD' and oficio = 'DIRECTOR'";
		q = session.createQuery(hql);
		System.out.println();
		System.out.println("Empleados cuyo número de departamento sea de Contabilidad y el oficio DIRECTOR");
		System.out.println();
		
		for(int i = 0; i < q.list().size(); i++) {
			
			Empleados emp = (Empleados) q.list().get(i);
			System.out.println(emp.getEmpNo() + ", " + emp.getApellido() + ", " + emp.getOficio() + ", " + emp.getDir() + ", " + 
			emp.getFechaAlt() + ", " + emp.getSalario() + ", " + emp.getComision() + ", " + emp.getDepartamentos().getDeptNo());
				
		}
		
		hql = "from Empleados where fechaAlt = '1990-12-17'";
		q = session.createQuery(hql);
		System.out.println();
		System.out.println("Empleados cuya fecha de alta es 1990-12-17");
		System.out.println();
		
		for(int i = 0; i < q.list().size(); i++) {
			
			Empleados emp = (Empleados) q.list().get(i);
			System.out.println(emp.getEmpNo() + ", " + emp.getApellido() + ", " + emp.getOficio() + ", " + emp.getDir() + ", " + 
			emp.getFechaAlt() + ", " + emp.getSalario() + ", " + emp.getComision() + ", " + emp.getDepartamentos().getDeptNo());
				
		}
		
		hql = "from Empleados where salario = (select max(salario) from Empleados where departamentos.loc = 'MADRID') and departamentos.loc = 'MADRID'";
		q = session.createQuery(hql);
		System.out.println();
		System.out.println("Empleado que tenga mejor sueldo y que sea del departamento Madrid");
		System.out.println();
		
		for(int i = 0; i < q.list().size(); i++) {
			
			Empleados emp = (Empleados) q.list().get(i);
			System.out.println(emp.getEmpNo() + ", " + emp.getApellido() + ", " + emp.getOficio() + ", " + emp.getDir() + ", " + 
			emp.getFechaAlt() + ", " + emp.getSalario() + ", " + emp.getComision() + ", " + emp.getDepartamentos().getDeptNo());
				
		}
		
		hql = "from Empleados where empNo = (select dir from Empleados where comision = (select max(comision) from Empleados))";
		q = session.createQuery(hql);
		System.out.println();
		System.out.println("Salario del director del empleado que más gana en comisión");
		System.out.println();
		
		for(int i = 0; i < q.list().size(); i++) {
			
			Empleados emp = (Empleados) q.list().get(i);
			System.out.println(emp.getApellido() + ", " + emp.getSalario());
				
		}
		
		hql = "from Empleados where fechaAlt in (select fechaAlt from Empleados where salario = (select max(salario) from Empleados where departamentos.loc = 'MADRID'))";
		q = session.createQuery(hql);
		System.out.println();
		System.out.println("Fecha de alta del empleado que más salario tiene en Madrid");
		System.out.println();
		
		for(int i = 0; i < q.list().size(); i++) {
			
			Empleados emp = (Empleados) q.list().get(i);
			System.out.println(emp.getApellido() + ", " + emp.getFechaAlt());
				
		}
		
		
		System.out.println();
		
		session.close();
		sesion.close();
		
	}

}
