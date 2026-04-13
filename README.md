# Desafio

- Este repositório possui 2 desafios em .Net, o desafio está dentro do _Program.cs_ de cada projeto.
- Para enviar a resposta, abra uma Pull Request para este repositório.

# Questionário

1. Cite 6 fatores do Twelve-Factor App e explique cada um deles.

**Resposta: 
	- Codebase: uma aplicação, um único repositório. Multiplos deploys(homologação, prod) sempre partem do mesmo código, nunca repositórios duplicados por ambiente
	- Dependencies: todas as dependências devem ser declaradas explicitamente(ex: NuGet, package.json) e não assumir que o ambiente está preparado.
	- Config: configurações que mudam por ambiente(chaves de API, strings de conexão) se tornam variáveis de ambiente e nunca "hardcoded" no código.
	- Backing Services: banco de dados, filas, serviços de e-mail são tratados como recurso anexáveis, a aplicação não deve distinguir entre serviços locais e remotos.
	- Logs: a aplicação não deve gerenciar os arquivos de Log. Ela somente escreve, outro serviço se encarrega de coletar e agregar.
	- Processess: a aplicação deve ser stateless. Qualquer estado persistente vai para o banco de dados, o que permite escalar.

2. Quais são as principais camadas no desenvolvimento de um software?

**Resposta:
	FrontEnd: Interface que permite interação do ususário, não deve conter regras de negócio.
	BackEnd: Todo o Core da aplicação onde se implementam as regras de negócio, acesso ao BD, integrações e mensageria.


3. Diferencie Arquitetura SOA X Arquitetura microserviços.

**Resposta:
	Ambas trababalham com serviços distribuídos, SOA prega a reutilização de serviços, os serviços e o acoplamento tendem a ser maiores, já Microserviços levam a descentralização ao etremo
	cada serviço com seu próprio BD e "deployavel" de forma independente.


4. Qual é o objetivo de um API Management na arquitetura de serviços distribuídos? Cite vantagens e desvantagens.

**Resposta:
	Centralizar o controle das APIS como autenticação, roteamento, versionamento e documentação
	-Vantagens: 
		Central de politicas de segurança(OAuth, Api Key)
		Observabilidade centralizada: logs, métricas e rastreamento de todas as chamadas
		Facilidade de versionamento
	-Desvantagens:
		Ponto único de falha, caso não haja redundância bem definida
		Latência adicional em cada chamadas
		Custo elevado de soluções Enterprise
	


5. Qual a diferença entre uma Struct e uma Class?

**Resposta:
	A principal diferença está na alocação de memória.


6. Explique a grande diferença entre .NET e .NET CORE.

**Resposta:
	A maior diferença está na compatibilidade Multiplataforma, já que o .NET foi construído para rodar exclusivamente no Windows. E performance.


7. Quais as principais diferenças entre REST e GRPC?

**Resposta:
	As difenças estão na versão do protocolo HTTP, REST utiliza 1.1 e gRPC utiliza 2, o payload Rest usa JSON e gRPC usa Protocol Buffers.
	


8. Explique como funciona um gerenciamento de rotas de uma SPA.

**Resposta:
	O servidor entrega uma página HTML única e toda navegação é gerenciada pelo JS no cliente, sem recarregar a pagina. Em frameworks como Angular(Router) o proprio
	framework troca o que é renderizado na tela sem a necessidade de fazer uma nova requisição ao servidor.


9. Falando sobre DevOps, comente o que conhece sobre.

**Resposta:
	O DevOps é mundo entre o desenvolvimento e a operação de fato, com o objetivo de entregar sempre um software com mais frequencia, qualidade e confiabilidade.
	O impacto real do DevOps é redução de tempo e aumento de confiança nos deploys.


10. Explique sobre um método agile.

**Resposta:
	Utilizando o Scrum como exemplo, o objetivo é organizar o trabalho em ciclos curtos, as Sprints. Dentro de cada sprint possuimos: Planning, Daily, Review e Retrospectiva


11. Comente sobre CI e CD e algumas ferramentas do dia a dia.

**Resposta:
	CI - um pipeline automatico, que compila o código, executa testes unitário e de integração, analisa qualidade. Objetivo principal é detectar falhas cedo antes de ir para produção.
	CD - Deploy automatizado,podendo ainda passar por uma aprovação manual ou ser totalmente automatico, desde que o pipeline do CI passe sem erros.
	
	Ferramentas mais comuns:
	Azuer DevOps Pipeline;
	Jenkins;
	SonarQube;


12. Qual a diferença entre Docker e Containers.

**Resposta:
	Container pode ser um processo isolado que roda em seu próprio filesystem, rede e variaveis de ambiente.
	Docker é a ferramenta, utilizada para criação e gerenciamento dos containers.
	


13. Qual a diferença entre Kubernetes e Openshift?

**Resposta:
	Ambos tem o mesmo principio, com a diferença que o OpenShift é uma versão enterprise, com suporte  e segurança reforçada.


14. Quais as vantagens e desvantagens sobre API e quais preocupações devemos ter quando escolhemos essa abordagem?

**Resposta:
	Vantagens:
		Front e back conseguem evoluir separadamente;
		A mesma API pode ser utilizada para Web, Mobile e parceiros externos
		Cada serviço pode escalar de forma independente
		Contratos claros facilitam a integração
	Desvantagens:
		Latência de rede
		Complexidade operaciona: versionamento, compatibilidade com sistemas legados
		Cada endpoint exposto pode se torna uma camada de ataque
	Ao escolher o desenvolvimento de uma API é necessário definir alguns pontos como:
		Versionamento - Como que a API irá evoluir, sem afetar usuários e clientes
		Contrato a ser utilizado - REST, gRPC
		Segurança - Autenticação, autorização, validações de input
		
		


15. Como conseguimos garantir um nível de segurança satisfatório no uso de APIS?

**Resposta:
	Definindo bem todas as camadas de segurança:
		- Auntenticação: O padrão atual é a utilização de OAuth 2.0 + JWT, o ideal é sempre validar o token para que não haja manipulação indevida;
		- Autorização: A validação do token junto com atribuições bem definidas, permitem que cada cliente/usuário tenha limites de execução.
		- Rate Limiting: evita abuso e ataques
		- Validação de input: para prevenção de injection attack
		- HTTPS obrigatório
		- CORS bem configurado por ambiente
		- Log: registrar todas as chamadas, facilita a investigação de incidentes


16. Para que serve uma arquitetura de mensagerias?

**Resposta:
	Para evitar problema de chamadas síncronas que ao falhar, se derruba toda a cadeia de processos e garantir consistência dos dados.
	


17. Explique a estratégia SAGA em arquitetura de microservice.

**Resposta:
	É um padrão para gerenciar transações distribuídas em microserviços, onde cada serviço possui o seu Banco de Dados próprio


18. Descreva o seu entendimento sobre GitOps utilizando Kubernetes.

**Resposta:
	GitOps é uma prática onde o Git é a fonte única de verdade para o estado desejado da infraestrutura e das aplicações. Tudo que deve existir no cluster Kubernetes está declarado em repositórios Git.

19. Descreva detalhadamente algum case de sucesso em que você atuou diretamente no desenvolvimento para solução de algum problema, cite tecnologias e os desafios enfrentados.

**Resposta:
	
Atuei no desenvolvimento de um módulo de auditoria automática de conhecimentos de embarque (BL — Bill of Lading) dentro de um sistema de gestão de processos de importação. O problema central era a inconsistência de dados entre o que chegava via EDI do armador e o que estava de fato registrado no manifesto físico em PDF — divergências de navio, viagem, containers, lacres, partes (shipper/consignee/notify) e fretes eram frequentes e detectadas tarde demais, gerando retrabalho operacional e risco de atraso em desembaraço aduaneiro.
O desafio técnico era duplo: primeiro, extrair de forma confiável os dados dos PDFs dos manifestos — documentos com layout semi-estruturado e bastante variação entre armadores. Segundo, comparar esses dados extraídos contra o que estava persistido no banco, identificar divergências campo a campo e gerar os ajustes necessários de forma auditável.
A solução foi construída em .NET com dois pilares principais:
O primeiro foi a integração com o Azure Document Intelligence (antigo Form Recognizer), que faz a extração dos dados do PDF por blocos — nós definimos modelos customizados que reconhecem os campos do manifesto por contexto de layout, retornando um JSON estruturado com as informações de cada BL, containers, lacres, fretes, NCM e partes envolvidas. Isso resolveu o problema da variabilidade de layout sem precisar de parsing frágil baseado em posição de texto.
O segundo pilar foi o motor de auditoria e conciliação, onde atuei diretamente. Construímos um pipeline que, para cada BL pendente no banco, localiza o correspondente no manifesto via índice por código, e então executa comparações campo a campo usando um sistema de normalização que leva em conta o tipo do campo definido num manual JSON (campos numéricos com escala, datas, texto com comprimento fixo). As divergências são registradas como interações rastreáveis no sistema.
Para os casos em que os dados precisavam ser corrigidos no arquivo EDI original — não só no banco — desenvolvemos um gerador de scripts SQL de conciliação. Ele usa um algoritmo de scoring para encontrar o melhor match entre registros existentes e os dados do PDF (por exemplo, identificar qual linha de container no banco corresponde a qual container do manifesto, mesmo com pequenas diferenças de formatação), e então gera UPDATEs cirúrgicos apenas nos campos que divergem, com comentários inline mostrando o de/para de cada alteração.
Os maiores desafios foram: garantir a idempotência do processo (rodar duas vezes não podia gerar duplicatas ou conflitos), lidar com a natureza de comprimento fixo do formato EDI do armador (cada campo tem posição e tamanho definidos no manual), e normalizar valores numéricos e datas que chegavam em formatos diferentes entre o PDF extraído e o banco — por exemplo, códigos de tipo de container como "40HC", "40HQ" e "4A" representam o mesmo equipamento dependendo do contexto.
Stack utilizada: C# / .NET, Azure Document Intelligence para extração dos PDFs, SQL Server, arquitetura de console application orquestrada por processo batch, com configuração externalizada e rastreabilidade de todas as alterações via log de interações por BL.
O resultado foi a eliminação praticamente total da correção manual de manifestos pela equipe operacional nos processos onde o módulo foi ativado, além de rastreabilidade completa de cada alteração feita pelo sistema.