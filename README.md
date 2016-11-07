# Bolsa-de-Empleo

### Descripción del Proyecto: 

El Proyecto consiste en un sitio web de una Bolsa de Empleos. Deberá soportar múltiples idiomas, proporcionar feeds y un API para desarrolladores.

### Los Casos de Uso del Proyecto

Las secciones siguientes describen las características que queremos aplicar en la primera versión / iteración del proyecto con algunos Casos de Uso sencillos. 
 
El sitio web tiene cuatro tipo de usuarios:

* Administrador: Propietario del Sitio Web  
* User: Visita la página web para buscar un puesto de trabajo y se postula para uno.  
* Poster: Visita la página web para envíar/ofrecer un puesto de trabajo  
* Affiliate: El re-publica algunos trabajos en su página web  

El proyecto tiene dos aplicaciones: el frontend (Casos de Uso F1 a F7, que están más abajo), donde los usuarios interactúan con el sitio web, y el backend (Casos de Uso B1 a B3), donde los administradores gestionan el sitio web. 
 
La aplicación backend tiene seguridad y requiere de credenciales para acceder.

## Caso de Uso F1: 

### En la página principal, los usuarios ven los últimos puestos de trabajo activos

Cuando un usuario entra a la página web, ve una lista de los puestos de trabajo activos. Los puestos de trabajo se clasifican por categoría y a continuación, por fecha de publicación (los nuevos puestos de trabajo primero). Para cada puesto de trabajo, sólo la ubicación, la posición, y la empresa se muestran. 
 
Para cada categoría, la lista sólo muestra los primeros 10 puestos de trabajo y un enlace permite listar todos los puestos de trabajo para una categoría determinada ( Caso de Uso F2 ). 
 
En la página principal, el usuario puede refinar la lista de puestos (Caso de Uso F2), o enviar un nuevo puesto de trabajo ( Caso de Uso F5 ). 

![F1](https://github.com/LeonT27/Bolsa-de-Empleo/blob/master/readmeInfo/img/f1.png)  

## Caso de Uso F2:  

### Un usuario puede solicitar todos los puestos de trabajo de una categoría determinada 

Cuando un usuario hace clic en el nombre de una categoría o en un enlace “more  obs” (más trabajos) en la página de inicio, verá todos los puestos de trabajo para esta categoría ordenados por fecha. 
 
La lista está paginada, con 20 puestos de trabajo por página  

![F2](https://github.com/LeonT27/Bolsa-de-Empleo/blob/master/readmeInfo/img/f2.png) 

## Caso de Uso F3:  

### Un usuario refina la lista con algunas palabras claves 

El usuario puede introducir algunas palabras clave para refinar su búsqueda. Las palabras clave pueden ser palabras se encuentra en los campos de la ubicación, la posición, la categoría, y de la compañía

## Caso de Uso F4:  

### Un usuario hace clic en un puesto de trabajo para ver información más detallada 

El usuario puede seleccionar un trabajo de la lista para ver información más detallada.

![F4](https://github.com/LeonT27/Bolsa-de-Empleo/blob/master/readmeInfo/img/f4.png) 

## Caso de Uso F5:  

### Un usuario envía un puesto de trabajo 

Un usuario puede enviar un puesto de trabajo. Un puesto de trabajo está formado por varias partes de información: 

* Compañía 
* Tipo (full-time, part-time, o freelance) 
* Logo (opcional) 
* URL (opcional) 
* Posición 
* Ubicación 
* Categoría (el usuario elige una de una lista de posibles categorías) 
* Descripción del trabajo (URL y correos electrónicos son enlazados de forma automática) 
* Cómo aplicar (URL y correos electrónicos son enlazados de forma automática) 
* Público (si el trabajo también pueden ser publicados en sitios web afiliados) 
* Email (email del oferente)  

No hay necesidad de crear una cuenta para crear un puesto de trabajo. 

El proceso es sencillo con sólo dos pasos: en primer lugar, el usuario rellena el formulario con toda la información necesaria para describir el trabajo y, a continuación, se valida la información con una vista previa de la página de empleo final. 

Incluso si el usuario no tiene cuenta, un puesto de trabajo puede ser modificado después, gracias a un URL concreto (protegido por un token dado al usuario cuando crea el puesto de trabajo). 
 
Cada puesto de trabajo está en línea durante 30 días (esto es configurable por el administrador - ver ( Caso de Uso B2 ). Un usuario puede volver a activar y extender la validez de un puesto de trabajo por 30 días extra pero sólo cuando el trabajo expira y entonces tiene menos de 5 días para hacerlo. 

![F5](https://github.com/LeonT27/Bolsa-de-Empleo/blob/master/readmeInfo/img/f5.png)  

## Caso de Uso F6:  

### Un usuario se registra para ser un afiliado 

Un usuario para re-publicar necesita convertirse en un afiliado y ser autorizado a utilizar la API de su sitio web. Para afiliarse, debe dar la siguiente información: 

* Nombre 
* Email 
* URL del sitio web 

La cuenta de afiliado debe ser activada por el administrador ( Caso de Uso B3 ). Una vez activada, el afiliado recibe un token vía email para poder usar la API. 
 
Cuando se registra, el afiliado puede también elegir los puestos de trabajo a obtener de un sub-conjunto de las categorías disponibles. 

## Caso de Uso F7: 

### Un afiliado recupera la lista activa de puestos de trabajo 

Un afiliado puede recuperar la actual lista de puestos de trabajo llamando a la API con su token de afiliado. La lista puede ser devuelta en formato XML, o JSON. 
 
La lista contiene la información pública disponible para un puesto de trabajo. 
 
El afiliado también puede limitar el número de puestos de trabajo a ser devueltos, y refinar su consulta especificando una categoría.

## Caso de Uso B1:  

### Un administrador configura el sitio web 

Un administrador puede modificar las categorías disponibles en el sitio web. También puede hacer algunos ajustes: 
 
* El número máximo de puestos de trabajo que figura en la página de inicio 
* Idioma de la página web 
* Número de días que un trabajo está en línea  

## Caso de Uso B2: 

### Un administrador gestiona los puestos de trabajo 

Un administrador puede editar y eliminar cualquier puesto de trabajo publicado. 

## Caso de Uso B3:  

### Un administrador gestiona los afiliados 

El administrador puede crear o editar los afiliados. Él es el responsable de la activación de un afiliado y también puede desactivarlo. 
 
Cuando el administrador activa un nuevo afiliado, el sistema crea un único token para ser utilizado por ese afiliado.
