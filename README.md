# Engineering Notes — Main Topics

<!-- Badges -->
[![Topic: OOP](https://img.shields.io/badge/Topic-OOP-blue?style=flat-square)](#oop)
[![Topic: Design Patterns](https://img.shields.io/badge/Topic-Design%20Patterns-purple?style=flat-square)](#design-patterns)
[![Topic: Software Architecture](https://img.shields.io/badge/Topic-Software%20Architecture-green?style=flat-square)](#software-architecture)
[![Topic: RAG Architecture](https://img.shields.io/badge/Topic-RAG%20Architecture-red?style=flat-square)](#software-architecture)
[![Topic: Domain Driven Design](https://img.shields.io/badge/Topic-Domain%20Driven%20Design-brown?style=flat-square)](#domain-driven-design-ddd)
[![Topic: Database Architecture](https://img.shields.io/badge/Topic-Database%20Architecture-orange?style=flat-square)](#database-architecture)
[![License: CC BY-NC-SA 4.0](https://img.shields.io/badge/License-CC%20BY--NC--SA%204.0-lightgrey?style=flat-square)](https://creativecommons.org/licenses/by-nc-sa/4.0/)
<p align="center">
  <img src="./assets/home.png" alt="Doble página del glosario con personaje estilo anime en el centro" width="720" />
  <br/>
  <em>Murakami Shiina</em>
</p>

---

## Index

- [Engineering Notes — Main Topics](#engineering-notes--main-topics)
  - [Index](#index)
    - [OOP](#oop)
    - [Design Patterns](#design-patterns)
      - [Creacionales](#creacionales)
      - [Estructurales](#estructurales)
      - [De Comportamiento](#de-comportamiento)
    - [Software Architecture](#software-architecture)
      - [RAG Architecture](#rag-architecture)
      - [Domain Driven Design (DDD)](#domain-driven-design-ddd)
    - [Database Architecture](#database-architecture)
  - [Conventions (useful as reference)](#conventions-useful-as-reference)
  - [Credits](#credits)

---

### OOP

Aquí puedes incluir tus apuntes sobre classes, objects, encapsulation, inheritance, composition, y principios clave como SOLID.

---

### Design Patterns

Breve guía de patrones de diseño clásicos (GoF), organizada por propósito. Úsalos como lenguaje común y como catálogo de soluciones probadas.

#### Creacionales

- **Factory Method**: delega la creación a subclases para evitar `new` explícitos.
- **Abstract Factory**: crea familias de objetos relacionados sin acoplarte a concreciones.
- **Builder**: separa construcción de representación; útil para objetos con muchos parámetros opcionales.
- **Prototype**: clona instancias existentes cuando crear desde cero es costoso.
- **Singleton**: instancia única global; úsalo con moderación (puede acoplar y dificultar tests).

**Ejemplo (Factory Method en Java):**

```java
interface Button { void render(); }
class WindowsButton implements Button { public void render(){ System.out.println("WinBtn"); } }
class MacButton implements Button { public void render(){ System.out.println("MacBtn"); } }
abstract class Dialog { // Creator
  public void open(){ Button b = createButton(); b.render(); }
  protected abstract Button createButton();
}
class WindowsDialog extends Dialog {
  protected Button createButton(){ return new WindowsButton(); }
}
class MacDialog extends Dialog {
  protected Button createButton(){ return new MacButton(); }
}
// Uso: new WindowsDialog().open(); o new MacDialog().open();
```

#### Estructurales

- **Adapter**: traduce interfaces incompatibles.
- **Facade**: API simplificada sobre un subsistema complejo.
- **Composite**: jerarquías parte‑todo con operaciones uniformes.
- **Decorator**: agrega responsabilidades en tiempo de ejecución sin herencia.
- **Proxy**: intermediario que controla el acceso (p. ej., lazy, remoto, cache).

#### De Comportamiento

- **Strategy**: intercambia algoritmos en tiempo de ejecución.
- **Observer**: notificación de cambios (pub/sub) entre sujeto y observadores.
- **Command**: encapsula una petición como objeto (deshacer, colas, logs).
- **State**: cambia comportamiento según el estado interno.
- **Template Method**: define el esqueleto de un algoritmo; subclases rellenan pasos.
- **Iterator**: recorre colecciones sin exponer su representación interna.
- **Mediator**: centraliza la comunicación para reducir acoplamientos entre colegas.

> **Tip:** Prefiere composición sobre herencia; muchos patrones (Strategy, Decorator) lo promueven.

---

### Software Architecture

Cubre patrones como Clean Architecture, DDD, microservices, layers, decoupling, y otros fundamentos de diseño escalable.

#### RAG Architecture

**RAG (Retrieval-Augmented Generation)**: Arquitectura para sistemas de IA que combinan modelos generativos con recuperación de información relevante desde fuentes externas, mejorando la precisión y contexto de las respuestas.

#### Domain Driven Design (DDD)

Enfoque de diseño centrado en el dominio del negocio, usando modelos y un lenguaje ubicuo para alinear el software con las reglas y procesos reales.

---

### Database Architecture

Cobertura de modelos relational vs NoSQL, schema design, normalization, indexes, transactions, optimization, y scalability.

---

## Conventions (useful as reference)

- **Bold**: términos importantes  
- _Italic_: aclaraciones o sinónimos  
- `Code`: fragmentos técnicos o ejemplos

---

## Credits

Ilustración estilo anime utilizada con fines personales para inspirar y establecer el tono del contenido.
