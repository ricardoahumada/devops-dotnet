# Integrate bitbucket - jenkins
- install plugin: bitbucket
- restart jenkins
- add webhook: http://&lt;ip>:8080/bitbucket-hook/
- config push/merge
- update jenkins task to trigger when a push is received
