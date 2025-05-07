# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta:**
Codebase: um repositório único para todas as instâncias.
Dependências: declaradas em manifesto, sem pacotes globais.
Configuração: variáveis de ambiente, separadas do código.
Serviços de apoio: bancos, caches e filas tratados como recursos conectáveis.
Build-release-run: fases distintas de compilação, empacotamento e execução.
Processos: instâncias stateless, qualquer estado fica em serviços externos.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:**
UI/Frontend: interface com o usuário.
Aplicação: orquestra fluxos e regras de uso.
Domínio/Negócio: regras puras da empresa.
Dados: acesso a bancos e repositórios.
Infraestrutura: integrações externas (APIs, filas, etc.).

3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:**
SOA: serviços maiores, usa ESB e SOAP, governança central.
Microserviços: serviços pequenos, comunicação leve (REST/gRPC), deploy independente.

4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:**
API Management:
Objetivo: gateway único para autenticação, controle de uso e monitoramento de APIs.
Vantagens: segurança, rate-limit e métricas centralizadas.
Desvantagens: ponto extra de latência e custo/complexidade adicionais.


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:**
Struct: tipo valor (cópia por valor), alocado na stack, sem herança.
Class: tipo referência (cópia de referência), alocado no heap, suporta herança.

6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:**
.NET Framework: Windows-only, monolítico.
.NET Core: cross-platform, modular, melhor desempenho.

7. Quais as principais diferenças entre REST e GRPC?

**Resposta:**
REST: HTTP/1.1 + JSON, mais simples e legível.
gRPC: HTTP/2 + Protobuf, binário e de alto desempenho, com streaming nativo.

8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:**
O roteador no cliente intercepta cliques, muda a URL via pushState ou hash e renderiza componentes sem recarregar a página.

9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:**
CI/CD: código sempre integrado, testado e entregue de forma automática e frequente.
IaC (Infraestrutura como Código): servidores e rede definidos em arquivos, reproduzíveis e versionados.
Monitoramento contínuo: métricas, logs e alertas em tempo real para manter a estabilidade.
Automação: builds, testes e deploys automatizados reduzem erros manuais.


10. Explique sobre um método agile.

**Resposta:**
Scrum (exemplo)
Ciclos curtos chamados sprints (1–4 semanas).
Papéis: Product Owner (prioriza backlog), Scrum Master (facilita o processo) e time de desenvolvimento.
Reuniões fixas: Sprint Planning, Daily Standup, Sprint Review e Retrospectiva.
Entregas incrementais e feedback rápido do cliente.

11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:**
CI (Integração Contínua): todas as mudanças de código são automaticamente construídas e testadas.
CD (Entrega/Deploy Contínuo): após os testes passarem, o software é automaticamente empacotado e enviado para homologação ou produção.
Ferramentas comuns:
Jenkins, GitLab CI/CD, GitHub Actions, Azure DevOps
Integram código (via Git), executam build, testes e deploy.

12. Qual a diferença entre Docker e Containers.

**Resposta:**
Container: unidade leve de execução que empacota app + dependências isoladas.
Docker: plataforma/ferramenta que cria, gerencia e distribui containers (imagens, registry, CLI).

13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:**
Kubernetes: open-source para deploy, escala e gestão de containers.
OpenShift: distribuição enterprise da Red Hat sobre Kubernetes, com:
Registry integrado, console web aprimorado
Autenticação/Autorização prontas
Suporte comercial e templates de apps

14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:**
Vantagens: desacoplamento, reuso, escalabilidade horizontal, interoperabilidade.
Desvantagens: latência de rede, versionamento, dependência de disponibilidade.
Preocupações ao adotar:
Segurança: autenticação e autorização
Performance: caching e rate-limiting
Compatibilidade: versionar sem quebrar clientes

15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:**
Transport Layer Security (TLS/HTTPS)
Autenticação/Autorização: OAuth2, API keys, JWT
Validação de entrada: evitar injeção de SQL/JSON
Rate-limiting e quotas: controlar uso exagerado
Monitoramento e logging: detectar e reagir a abusos

16. Para que serve uma arquitetura de mensagerias?

**Resposta:**
Desacoplamento
Comunicação assíncrona: filas
Escalabilidade e resiliência

17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:**
Série de transações locais coordenadas que mantêm consistência eventual.
Coreografia: cada serviço emite eventos e reage a eventos de outros.
Orquestração: um serviço “orquestrador” dirige os passos e envia comandos.
Em caso de falha, cada serviço executa uma transação de compensação para desfazer o efeito anterior.

18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:**
Git como fonte de verdade: toda configuração (YAML de pods, services, etc.) fica num repositório.
Controller automático: ferramentas (Flux, Argo CD) observam mudanças no Git e aplicam no cluster.
Vantagens: deploys auditáveis, reversão fácil, rastreabilidade e automação de infraestrutura.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:**
Nos meus três anos na empresa, participei de vários projetos de impacto. Aqui vão alguns cases de sucesso:
Automação do Fluxo de Compras ao Pagamento
Desafio: processos 100% manuais, envolvendo papéis e troca de e-mails entre várias áreas (compras, aprovação, financeiro), gerando atrasos e retrabalho.
Solução: criei um fluxo completo no Fluig, com formulários online para solicitações, rotas de aprovação automáticas e integração direta com o módulo financeiro.
Tecnologias: JavaScript (front-end no Fluig), Fluig BPM, MySQL.
Resultados:
Redução de 80% no tempo de aprovação
Eliminação de 100% do papel físico
Visão em tempo real do status de cada requisição

Intranet Corporativa para 600+ Usuários
Desafio: comunicação interna descentralizada e falta de um portal único para anúncios, documentos e formulários.
Solução: desenvolvi uma intranet em C#, integrada ao SharePoint, com cadastro de notícias, repositório de arquivos e áreas colaborativas.
Tecnologias: C#, ASP.NET, SQL Server, SharePoint.
Resultados:
Adoção por mais de 600 colaboradores
Centralização de conteúdo e redução de e-mails informativos

Sistema de Follow-Up para Duas Filiais
Desafio: filiais (Eudmarco e FCALog) sem ferramenta padronizada para acompanhar status de parceiros marítimos e de aviação.
Solução: criei um web app com login via Azure AD, painel de acompanhamento de cadastros e dashboards por filial.
Tecnologias: C#, ASP.NET Core, Angular, SQL Server, autenticação Microsoft.
Resultados:
Comunicação unificada entre equipes internas
Visibilidade em tempo real do status de cada parceiro

Projeto de IA para Monitoramento de Áreas Restritas
Desafio: garantir que ninguém entrasse em áreas perigosas (pátio de carga, conveniências) sem equipamento de segurança.
Solução: treinei redes neurais convolucionais (TensorFlow/Keras) em Python para detectar câmeras que flagrem presença e uso de EPI; o sistema dispara alertas por e-mail e notifica as equipes de segurança.
Tecnologias: Python, TensorFlow, Keras (RNAC), C#, Angular (front), integração de e-mail.
Resultados:
Aumento de 60% na aderência ao uso de EPIs
Resposta em menos de 5 s após violação de área

 Plataforma de Clima Organizacional
Desafio: compreender o engajamento e satisfação de mais de 400 colaboradores de forma rápida e intuitiva.
Solução: desenvolvi um quiz interativo com testes e relatórios gráficos, onde cada colaborador responde anonimamente e a liderança acessa dashboards de feedback.
Tecnologias: C#, ASP.NET, SQL Server, React .
Resultados:
85% de participação nos quizzes
Insights acionáveis para melhorar políticas internas

Além desses projetos, também atuo como freelancer criando bots para WhatsApp e Discord usando Node.js, atendendo a diversos clientes e servidores.
Escopo: automação de atendimento, moderação e notificações.
Tecnologias: Node.js, bibliotecas como whatsapp-web.js e discord.js.
Impacto: facilito o suporte e a interação em múltiplas comunidades, entregando soluções personalizadas e escaláveis.

Chat interno “ABAia”
Desafio: oferecer um canal unificado de comunicação e consulta de informações internas, além de facilitar acesso a documentos espalhados na rede.
Solução: desenvolvi um chat web que integra a API do ChatGPT (via chave de autenticação) para responder dúvidas em linguagem natural e, ao mesmo tempo, pesquisa arquivos na rede por palavras-chave.
Tecnologias: C# (backend), front-end Angular, integração com ChatGPT API e módulos de indexação de arquivos na rede.
Resultados:
Respostas automáticas a perguntas frequentes
Acesso rápido a arquivos internos sem sair do chat
Melhora na agilidade de atendimento e suporte aos colaboradores


Entre outros...