# Respostas do Questionário Técnico

## 1. Fatores do Twelve-Factor App

1. **Codebase**: Um repositório versionado único para todo o código da aplicação, com múltiplos deploys possíveis a partir deste mesmo códigobase.

2. **Dependencies**: Todas as dependências devem ser explicitamente declaradas e isoladas, nunca dependendo de pacotes implicitamente instalados no sistema.

3. **Config**: Configurações que variam entre ambientes (dev, staging, production) devem ser armazenadas no ambiente, nunca no código.

4. **Backing Services**: Serviços auxiliares (banco de dados, cache, etc) devem ser tratados como recursos anexados, com capacidade de substituição sem alterações no código.

5. **Build, Release, Run**: Separação estrita entre estágio de build (compilação), release (combinação com configurações) e run (execução no ambiente).

6. **Processes**: A aplicação deve executar como um ou mais processos stateless, não mantendo estado entre requisições.

## 2. Principais Camadas no Desenvolvimento de Software

As principais camadas arquiteturais são:

- **Apresentação (UI)**: Interface com o usuário final (web, mobile, desktop)
- **Aplicação**: Camada que contém as regras de negócio principais
- **Domínio**: Modelos de dados e lógica de domínio
- **Infraestrutura**: Acesso a dados, serviços externos e componentes técnicos
- **Cross-cutting**: Funcionalidades transversais como logging, segurança e monitoramento

## 3. Diferença entre Arquitetura SOA e Microserviços

| Característica       | SOA                          | Microserviços                |
|----------------------|------------------------------|------------------------------|
| Acoplamento          | Mais acoplado                | Altamente desacoplado        |
| Comunicação          | Frequentemente via ESB       | Comunicação direta (HTTP/RPC)|
| Tamanho             | Serviços maiores             | Serviços pequenos e focados  |
| Banco de Dados      | Compartilhado                | Isolado por serviço          |
| Governança          | Centralizada                 | Descentralizada              |

## 4. API Management em Arquiteturas Distribuídas

**Objetivo Principal**: Atuar como camada intermediária que centraliza o gerenciamento, segurança e monitoramento de APIs em ambientes distribuídos.

**Vantagens**:
- Implementação centralizada de políticas (rate limiting, caching)
- Transformação de payloads
- Agregação de métricas e logs
- Facilidade no versionamento de APIs
- Segurança unificada (JWT, OAuth)

**Desvantagens**:
- Pode se tornar um single point of failure
- Adiciona latência às chamadas
- Complexidade adicional na arquitetura
- Custo de implementação e manutenção

- ## 5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
```
// Struct (tipo de valor)
public struct Coordenada {
    public double Latitude;
    public double Longitude;
}

// Class (tipo de referência)
public class Usuario {
    public string Nome { get; set; }
    public string Email { get; set; }
}
```

- Structs são alocados na stack, classes na heap
- Structs não suportam herança
- Structs são passados por valor, classes por referência
- Structs são mais eficientes para pequenos objetos imutáveis

  ## 6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
**.NET Framework**:
- Plataforma Windows-only
- Runtime único para toda máquina
- Integração profunda com Windows
- Sistema de build tradicional

**.NET Core** (.NET 5+):
- Runtime cross-platform (Windows/Linux/macOS)
- Modelo de deploy self-contained
- Modular e open-source
- Performance otimizada
- CLI tools unificadas

## 7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
**REST**: é um tipo de arquitetura para APIs que usa HTTP como protocolo de comunicação. Ele define um conjunto de constraints como statelessness, uso de recursos identificados por URIs, e operações baseadas nos métodos HTTP padrão (GET, POST, PUT, DELETE).

Cada endpoint representa um resource, geralmente em JSON, e a comunicação é stateless — ou seja, cada requisição carrega todas as infos necessárias, sem depender de contexto do servidor. A ideia é manter a API simples, escalável e cacheável. REST não é um protocolo, é uma convenção.
Resumindo... REST é sobre manipular recursos via HTTP com um contrato bem definido e previsível.

**gRPC**: Não tenho conhecimento sobre GRPC

## 8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
O gerenciamento de rotas numa SPA basicamente gira em torno do controle da History API pra manipular o estado de navegação sem hard reload. A ideia é interceptar as mudanças de URL e fazer renderização declarativa dos componentes com base no path atual, tudo client-side. A gente mantém o payload da aplicação carregado e só faz swap de views dentro de um container central.

Podemos exemplificar usando o angular  que por baixo dos panos, escuta o evento popstate e usa o LocationStrategy pra controlar o histórico de navegação. A cada push de rota com router.navigate() ou [routerLink], o Angular resolve a nova rota, instancia o componente e faz o inject no RouterOutlet. E se tiver rota aninhada, ele resolve a árvore de rotas recursivamente, criando uma estrutura nested dentro dos outlets correspondentes.

O setup inicial é bem direto: você define as rotas no módulo de roteamento usando o RouterModule.forRoot(routes), passando um array de objetos com path, component, e eventualmente canActivate, children, loadChildren, etc. Isso é o que mapeia o path da URL pra um determinado componente da aplicação.

## 9. Falando sobre DevOps, comente o que conhece sobre: DevOps é uma cultura e conjunto de práticas que integram development e operations, com foco em automação, CI/CD, infraestrutura como código (IaC) e colaboração contínua. O objetivo é reduzir o lead time, aumentar a confiabilidade e permitir entregas frequentes e estáveis. Ferramentas comuns: Docker, Kubernetes, Jenkins, Terraform.

## 10. Explique sobre um método agile: Scrum é um framework ágil baseado em ciclos curtos chamados sprints (geralmente 1 a 4 semanas), com papéis bem definidos contendo cerimônias como Daily Stand-up, Sprint Planning, Review e Retrospective. O foco é entregar incrementos funcionais do produto em cada sprint, com forte ênfase em feedback e melhoria contínua.

## 11. Comente sobre CI e CD e algumas ferramentas do dia a dia: CI/CD é um conjunto de práticas que automatizam o ciclo de vida do software. CI (Continuous Integration) garante que cada commit no repositório dispare builds e testes automáticos, ajudando a identificar falhas cedo. Já o CD pode ser dividido em Continuous Delivery (o código está sempre pronto para ir à produção, mas o deploy é manual) e Continuous Deployment (deploys automáticos direto pra produção). No dia a dia, usamos ferramentas como Jenkins, GitLab CI e CircleCI para CI, e ArgoCD, Spinnaker e Flux para CD. Também entram no combo ferramentas de infraestrutura como Terraform e Pulumi, e de testes como Selenium, Jest e xUnit. Tudo isso pra manter entregas rápidas, seguras e contínuas.

## 12. Qual a diferença entre Docker e Containers?
Containers são uma tecnologia de virtualização a nível de sistema operacional, proporcionando isolamento através de namespaces e cgroups. O padrão utilizado é o OCI (Open Container Initiative). Já o Docker é uma plataforma completa para trabalhar com containers, oferecendo o Docker Engine (runtime), Dockerfile (para criar imagens), Docker Compose (orquestração local) e o Docker Hub (um registro público de imagens). O Docker facilita a criação, distribuição e gerenciamento de containers, tornando a tecnologia mais acessível e simplificada.

## 13. Qual a diferença entre Kubernetes e OpenShift?
O Kubernetes é um projeto open-source, amplamente adotado como padrão para organização de containers, com uma arquitetura extensível e uma comunidade ativa.
Já o OpenShift é uma distribuição empresarial do Kubernetes feita pela Red Hat, porém não tenho mais informações sobre ele por não ter usado ou estudado.

## 14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?
Vantagens das APIs incluem o desacoplamento entre cliente e servidor, evolução independente, reutilização de funcionalidades e maior interoperabilidade. Porém, desvantagens envolvem o overhead de comunicação, complexidade distribuída e desafios de versionamento. Ao escolher APIs, é essencial ter um design cuidadoso dos contratos, documentação clara (como OpenAPI/Swagger), uma estratégia sólida de versionamento (URL ou header), garantir segurança (OAuth, rate limiting), e manter observabilidade (métricas e tracing).

## 15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIs?
Para garantir a segurança em APIs, é crucial implementar boas práticas de autenticação (como OAuth 2.0, OpenID Connect, JWT ), proteção (validação rigorosa de input, CORS restritivo), e monitoramento (com logging centralizado, detecção de anomalias e auditoria de acesso). Essas estratégias ajudam a proteger as APIs contra acessos não autorizados e garantir a integridade dos dados.

# Questionário Técnico - Parte 4/4

## 16. Para que serve uma arquitetura de mensagerias?
Uma arquitetura de mensageria serve para desacoplar sistemas e permitir a comunicação assíncrona entre eles. Ela facilita a troca de mensagens entre diferentes componentes ou serviços, muitas vezes de forma distribuída, sem que os sistemas estejam diretamente interligados. Isso melhora a escalabilidade, a resiliência e a flexibilidade do sistema.

## 17. Explique a estratégia SAGA em arquitetura de microservice.
Não tenho conhecimento sobre o tema

## 18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.
Não tenho conhecimento sobre o tema

## 19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Contexto**: Atualização Total de um Sistema de Apoio Decisorio que inicialmente utilizava WindowsForms com arquitetura monolito contendo uma page chamada funcServer que no codeBehinde tinha o core de funcionalidades da aplicação e estava sendo consumido pelas pages do monilito via AJAX. 
Existia um segundo projeto em Angular na versão 8 que servia apenas para encapsular as pages do monilito usando iframe
**OBS**: Cada page correspondia a uma função ou modulo de um sistema e para chamar a page dentro do iframe era necessário passar os dados via url. Dados como (SessionID, Matricula, Setor).

**Solução implementada**:
- Arquitetura: [MVC]
- Stack técnico: 
  - Backend: [.NET Framework/C#/Onbase]
  - Frontend: [ASP.NET CORE MVC]
  - Infra: [K8s/AWS/Azure]
  - CI/CD: [GitHub Actions/Azure Devops]

**Desafios**:
1. [Desafio técnico 1] - Transformar o Monolito em uma API REST usando a .Net Framework pois era ultima versão suportada pelo Onbase
2. [Desafio técnico 2] - Code Review e todas as funcionalidades de upload, por solicitação da infra
3. [Desafio técnico 2] - Revalidação de todas as regras de negocio, pois o client informou que estavam defasadas.
4. [Desafio organizacional] - Organização de tempo entre entrega do novo sistema e Suporte do Sistema Legado

**Resultados**:
- Métricas de melhoria (performance, estabilidade do sistema, Processos mais coesos)
- Próximos passos: Implementações de novas funcionalidade solicitadas pelo cliente
