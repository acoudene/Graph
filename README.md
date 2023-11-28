# Graph

La stack technique de mon prototype :
- Asp.Net Core 8
- EF Core 8
- Une base SQL-Server :
  - Automatiquement embarquée dans un container Docker lancé par code
  - La base est créée et remplit automatiquement à la première requête.

L’exemple en images.

Ici le requêteur :
-	A gauche, je demande tous les patients en ne prenant que leur id+name, avec toutes les requests associées en ne prenant que le patientid, le requestid et l’accessnumber, et tous les PrescribedTests en ne prenant que le requestId et le code.
-	Les valeurs en réponse, comme indiqué, sont des valeurs générées donc j’ai utilisé des Guid pour éviter les conflits d’index uniques.
-	
![image](https://github.com/acoudene/Graph/assets/12967802/ee3f15d7-6483-443d-ba31-ee7f8818e996)



 

Et on voit que pendant l’exécution mon container Docker pour Sql-Server tourne comme attendu :

![image](https://github.com/acoudene/Graph/assets/12967802/e53baf61-e14c-4650-93a9-667ecf80f62d) 
