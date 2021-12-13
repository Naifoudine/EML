# Veille sur le format EML
## Qu'est-ce qu'un fichier EML ?

Un fichier EML est un message électronique enregistré par une application de messagerie, telle que Microsoft Outlook ou Apple Mail. Il contient le contenu du message, ainsi que l'objet, l'expéditeur, le(s) destinataire(s) et la date du message. Les fichiers EML peuvent également stocker une ou plusieurs pièces jointes, qui sont des fichiers envoyés avec le message.

## Brève histoire de l'EML
Les spécifications du format de fichier EML sont disponibles conformément au format standard [RFC 822](http://www.ietf.org/rfc/rfc0822.txt) . Avant la RFC-822, la RFC-733 régissait les règles d'échange de messages sur le réseau jusqu'en 1982, la première a été créée pour améliorer le latéral en établissant des normes ARPA. Parallèlement, Microsoft a créé ses propres modules COM pour le développement de son propre client de messagerie, à savoir Outlook Express. La RFC-822 a pris le chemin de l'établissement en tant que format propriétaire lorsque Microsoft s'est écarté du standard ouvert et a créé le format de fichier [PST](https://docs.fileformat.com/email/pst/) où les e-mails sont enregistrés dans un format de base de données hautement structuré. Cela entraînait des problèmes pour les utilisateurs de clients de messagerie non Microsoft lorsque les e-mails étaient transférés à partir de Microsoft Outlook.

C'était en 2001 lorsque la norme 822 a été améliorée pour devenir 2822 - Internet Message Format, qui est actuellement utilisé pour créer, lire et envoyer des messages EML au format MIME RFC-822.

## Spécifications du format de fichier EML[](https://docs.fileformat.com/email/eml/#eml-file-format-specifications)

Les fichiers EML comprennent deux sections distinctes :

-   En-têtes - Contient des informations sur l'en-tête du message
-   Corps du message - Contient une série d'informations pouvant inclure le contenu du message, des images intégrées et des pièces jointes
- 
### Informations sur les en-têtes[](https://docs.fileformat.com/email/eml/#headers-information)

Un fichier EML se compose d'informations d'en-tête et éventuellement de corps de message. Chaque ligne d'en-tête de l'EML comporte deux parties séparées par deux points « : ». Le premier s'appelle Nom d'en-tête et celui qui suit les deux points est le corps de l'en-tête. Par exemple, de tels en-têtes incluent :

-   Adresse e-mail de l'expéditeur
-   Adresse courriel du destinataire
-   Objet de l'e-mail
-   Horodatage du message

**Exemple d'en-tête**
De : [JohnDoe@exemple.com](mailto:JohnDoe@exemple.com)
À : [Alice@exemple.com](mailto:Alice@exemple.com)
Date : jeu. 8 mars 2021 09:43:37 +0400
Sujet : Hello Alice

### Corps du message
Le corps du message EML contient les informations principales de l'e-mail sous forme de texte, d'hyperliens et de pièces jointes. Le corps de l'e-mail peut contenir du texte lisible, mais ce n'est pas nécessaire. Dans ce cas, le corps du message peut être vide ou contenir des données de pièces jointes codées.

Le contenu du corps du message est décrit par son Content-Type qui permet aux applications de lecture de lire les informations dans les formats respectifs. Il représente en fait la nature et le format d'un document. La structure d'un type MIME ou d'un type de contenu est très simple ; il se compose d'un type et d'un sous-type, deux chaînes, séparées par un '/'. Aucun espace n'est autorisé. Le `type` représente la catégorie et peut être de type discret ou multipartite. Le `subtype` est spécifique à chaque type. La liste des types, qui entrent dans la catégorie Content-Type, est longue mais certains types de contenu importants sont les suivants :

|Type            |Description                    |Exemple de sous-types        |
|----------------|-------------------------------|-----------------------------|
|texte           |Représente un format lisible par l'homme|text/plain, text/html, text/css, text/javascript            |
|image           |Représente une image de tout type à l'exception des vidéos |image/bmp, image/png, image/jpg, image/gif|
|audio           |Représente n'importe quel format de fichier audio|audio/mdi, audio/wav|
|application     |Représente tout type de données binaires|application/octet-stream, application/vnd.mspowerpoint, application/xhtml+xml, application/xml, application/pdf

### Représentation de la pièce jointe dans le corps EML
Le corps EML contient des limites pour chaque type de contenu qu'il contient. La pièce jointe dans le corps du message est identifiée par son Content-Type et Content-Disposition, comme illustré dans l'exemple suivant :

Content-Type: text/plain; charset#“windows-1252”; name#“apple app store.txt” Content-Disposition: attachment; filename#“apple app store.txt” Content-Transfer-Encoding: base64 X-Attachment-Id: f_jkhztmd02

Comme on peut le voir, le Content-Disposition défini sur pièce jointe permet aux applications de lecture d'obtenir des informations sur les pièces jointes telles que le nom du fichier de pièce jointe et l'encodage de transfert. Les informations d'en-tête de la pièce jointe sont suivies du contenu codé de la pièce jointe qui doit être lu.
#### Exemple de feuille de calcul en pièce jointe
Content-Type: application/vnd.openxmlformats-officedocument.spreadsheetml.sheet; name#“english_spodr.xlsx” Content-Disposition: attachment; filename#“english_spodr.xlsx” Content-Transfer-Encoding: base64 X-Attachment-Id: f_jkhztmd43

## Références
-   [RFC 822](http://www.ietf.org/rfc/rfc0822.txt)
- https://docs.fileformat.com/email/eml/
