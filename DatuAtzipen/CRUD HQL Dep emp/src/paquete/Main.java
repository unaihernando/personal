package paquete;

import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.List;

import org.hibernate.Query;
import org.hibernate.Session;
import org.hibernate.SessionFactory;
import org.hibernate.Transaction;

import hiberclass.Departamentos;
import hiberclass.Empleados;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		String hql = new String();
		Transaction tx = null;	
		SessionFactory sesion = HibernateUtil.getSessionFactory();
		Session session = sesion.openSession();	
		tx = session.beginTransaction();
			
		// Insertar nuevo departamentos con de INFORMATICA.
		
		Departamentos informatica = new Departamentos();
		informatica.setDeptNo((byte) 50);
		informatica.setDnombre("INFORMATICA");
		informatica.setLoc("SAN IGNACIO");
		session.save(informatica);
		tx.commit();
		System.out.println();
		System.out.println("Departamento insertado");
		System.out.println();
		
		 // Insertar un empleado de informatica que sea DIRECTOR y con salario de 2300.
		
		tx = session.beginTransaction();
		
		Empleados empleado = new Empleados();
		empleado.setEmpNo((short) 8000);
		empleado.setOficio("DIRECTOR");
		empleado.setApellido("BARRIO");
		empleado.setComision(null);
		empleado.setDir(null);
		
		Calendar myCalendar = new GregorianCalendar(2020, 12-1, 9);
		Date fecha = myCalendar.getTime();
		
		empleado.setFechaAlt(fecha);
		empleado.setSalario((float) 2300);
		empleado.setDepartamentos(informatica);
		session.save(empleado);
		tx.commit();
		System.out.println();
		System.out.println("Empleado insertado");
		System.out.println();
			
		// Modificamos el salario de GIL a 1300
		
		tx = session.beginTransaction();		
		hql = "from Empleados where apellido = 'GIL'";
		Query q = session.createQuery(hql);
		
		Empleados gil = (Empleados) q.uniqueResult();
		
		gil.setSalario((float)1300);
		
		session.update(gil);
		tx.commit();
		System.out.println();
		System.out.println("Salario actualizado");
		System.out.println();
		
		//	Eliminamos los empleados del departamento 20.
		
		tx = session.beginTransaction();
		hql = "from Empleados where departamentos.deptNo = 20";
		q = session.createQuery(hql);
		
		@SuppressWarnings("unchecked")
		List<Empleados> lista = q.list();
		
		for (int i = 0; i < lista.size(); i++) {
			
			empleado = (Empleados)lista.get(i);
			session.delete(empleado);
		}
		
		tx.commit();
		System.out.println();
		System.out.println("Empleados borrados");
		System.out.println();
		
		// Eliminar un empleado del departamento de CONTABILIDAD cuyo salario sea el mayor de ese departamento.
			
		tx = session.beginTransaction();
		hql = "from Empleados where salario = (select max(salario) from Empleados where departamentos.dnombre = 'CONTABILIDAD') and departamentos.dnombre = 'CONTABILIDAD'";
		q = session.createQuery(hql);
		
		@SuppressWarnings("unchecked")
		List<Empleados> lista2 = q.list();
		
		for (int i = 0; i < lista2.size(); i++) {
			
			empleado = (Empleados)lista2.get(i);
			session.delete(empleado);
		}
		
		tx.commit();
		
		System.out.println("Borrado realizado");
		
		session.close();
		sesion.close();
		
	}

}
