# Questionário Técnico – .NET, Arquitetura e DevOps

## Cite 6 fatores do Twelve-Factor App e explique cada um deles

1. **Codebase**  
   Uma única base de código versionada por app. Pode haver múltiplos deploys, mas a base de código é única.

2. **Config**  
   Configurações devem estar fora do código, geralmente em variáveis de ambiente. Isso facilita a troca entre ambientes (dev, staging, produção).

3. **Backing Services**  
   Trate banco de dados, cache, filas etc. como serviços externos substituíveis, sem acoplamento forte com a aplicação.

4. **Build, Release, Run**  
   Separação clara entre _build_ (compilar o código), _release_ (associar configuração) e _run_ (executar).

5. **Processes**  
   A aplicação deve ser stateless (sem estado persistente entre execuções). Qualquer estado deve ser externo (cache, banco etc).

6. **Logs**  
   Logs devem ser emitidos como _streams_ de eventos. Não salvar logs em arquivos locais. Usar ferramentas externas para agregação e análise.

---

## Quais são as principais camadas no desenvolvimento de um software?

- **Apresentação (UI)**: Interface com o usuário.
- **Aplicação**: Orquestra os casos de uso.
- **Domínio**: Contém as regras de negócio.
- **Infraestrutura**: Integrações externas (banco, APIs etc).
- **Persistência**: Comunicação com o banco de dados (ex: EF Core).

---

## Diferencie Arquitetura SOA x Arquitetura de Microserviços

- **SOA**: Serviços robustos, integrados por um barramento (ESB), com uso de XML e contratos compartilhados.
- **Microserviços**: Serviços pequenos, independentes, geralmente comunicando por REST/gRPC, focados em escalabilidade e manutenção isolada.

---

## Qual o objetivo de um API Management?

Gerenciar APIs com segurança, controle de versão e monitoramento.

- **Vantagens**: Segurança, analytics, controle de acesso, rate limit.
- **Desvantagens**: Custo e curva de aprendizado.
- **Exemplo**: Azure API Management.

---

## Qual a diferença entre uma Struct e uma Class?

- **Struct**: Tipo valor (stack), sem herança, mais leve, ideal para tipos simples.
- **Class**: Tipo referência (heap), suporta herança/polimorfismo, ideal para lógica complexa.

---

## Diferença entre .NET e .NET Core

- **.NET Framework**: Antigo, apenas para Windows.
- **.NET Core** (hoje apenas .NET): Cross-platform, moderno, mais leve e com melhor performance.

---

## REST x gRPC

- **REST**: Usa HTTP + JSON, amigável para web/navegadores, simples.
- **gRPC**: Usa HTTP/2 + Protobuf, muito mais performático, ideal para comunicação entre serviços.

---

## Como funciona o gerenciamento de rotas em uma SPA?

Usa **roteamento client-side** com bibliotecas como React Router. A troca de rotas não recarrega a página, apenas muda o componente renderizado dinamicamente.

---

## DevOps – o que você conhece?

Integra desenvolvimento e operações com automação. Ferramentas como:

- GitHub Actions
- Docker
- Kubernetes
- Prometheus

Visa entregas frequentes, seguras e automatizadas.

---

## Método Ágil

**Scrum**: Método mais comum. Sprints curtas (geralmente 2 semanas), backlog priorizado, reuniões diárias e feedback contínuo.

---

## CI/CD – Integração e Entrega Contínua

- **CI (Continuous Integration)**: Build e testes automáticos a cada commit.
- **CD (Continuous Delivery/Deployment)**: Entrega/deploy automático ou sob aprovação.

**Ferramentas**: GitHub Actions, Azure Pipelines, Jenkins.

---

## Docker x Containers

- **Container**: Conceito de empacotar uma aplicação com suas dependências em um ambiente isolado.
- **Docker**: Ferramenta/plataforma que gerencia a criação e execução de containers.

---

## Kubernetes x OpenShift

- **Kubernetes**: Orquestrador de containers open-source.
- **OpenShift**: Plataforma baseada no Kubernetes com funcionalidades enterprise (UI, CI/CD, RBAC etc).

---

## Vantagens e Desvantagens de APIs

- **Vantagens**: Integração fácil, escalabilidade, reutilização de serviços.
- **Desvantagens**: Latência, segurança, versionamento.
- **Preocupações**: Autenticação, validação, throttling, logging, rate limit.

---

## Segurança em APIs

Para garantir segurança:

- Usar HTTPS
- Autenticação JWT / OAuth2
- Validação de entrada
- CORS
- Logs centralizados
- Rate limiting

---

## Para que serve uma arquitetura de mensageria?

Permite **comunicação assíncrona** entre serviços, reduz acoplamento e melhora escalabilidade.

**Ferramentas**: RabbitMQ, Kafka, Azure Service Bus.

---

## Estratégia SAGA em microserviços

Controla **transações distribuídas** com consistência eventual.

- **Orquestrada**: Um serviço coordena.
- **Coreografada**: Cada serviço reage a eventos.

---

## GitOps com Kubernetes

**Git como fonte de verdade** para a configuração de clusters.

Com ferramentas como **ArgoCD** e **Flux**, qualquer mudança no Git é automaticamente aplicada no cluster, com controle de auditoria.

---

## Case de Sucesso

Trabalhei na migração de um monólito para microserviços utilizando:

- **.NET 6**, **EF Core**, **RabbitMQ**
- Contêineres com **Docker**
- Orquestração via **Kubernetes**
- **CI/CD** com GitHub Actions

**Desafio**: manter consistência dos dados e deploy contínuo sem downtime. O ganho foi em escalabilidade, confiabilidade e velocidade de entrega.

---