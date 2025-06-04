Sistema de gestión de encuestas para evaluar actividades y servicios dentro de una institución educativa. Construido con .NET, MySQL y Docker, aplicando arquitectura limpia para mantener el código organizado y escalable.

---

## 🚀 Tecnologías Utilizadas

- .NET 8  
- Entity Framework Core  
- MySQL 8  
- Docker & Docker Compose  
- Arquitectura Limpia (Clean Architecture)

---

## 📁 Estructura del Proyecto

```text
SurveyActivityCampus/
├── Domain/             # Entidades del dominio
├── Application/        # Casos de uso y lógica de negocio
├── Infrastructure/     # Repositorios y configuración de la base de datos
├── SurveyApi/          # API RESTful con controladores y configuración
├── docker-compose.yml  # Configuración de contenedores
├── SurveyApi/Dockerfile
└── README.md
```

⚙️ Instrucciones de Uso (Docker)
1. Clona el repositorio
```bash
git clone https://github.com/sebastianVis/SurveyActivityCampus.git
cd SurveyActivityCampus
```
2. Ejecuta los contenedores
```bash
docker-compose up --build
```
🧠 Funcionalidades Principales
Creación de encuestas con preguntas y subpreguntas.

Soporte para opciones múltiples.

Registro de respuestas con comentarios opcionales.

Organización por capas para facilitar el mantenimiento y escalabilidad.

🧪 Scripts y Migraciones
Ejecutar migraciones con Entity Framework Core
```bash
dotnet ef migrations add InitialCreate -p Infrastructure -s SurveyApi
dotnet ef database update -p Infrastructure -s SurveyApi
```
Instalar EF Core Tools
```bash
dotnet tool install --global dotnet-ef
```
## 🧑‍💻 Autor
Proyecto desarrollado por @sebastianVis
