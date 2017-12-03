$HostNameForCertificate=$env:computername
$AddionalHostNames=”localhost”
$RootCACert=New-SelfSignedCertificate -certstorelocation cert:\localmachine\my -FriendlyName “Local Certification Authority” -TextExtension @(“2.5.29.37={text}1.3.6.1.5.5.7.3.3”) -KeyUsage CertSign -KeyAlgorithm RSA -KeyLength 2048 -dnsname $HostNameForCertificate,$AddionalHostNames
#export cert to import it on other machines in root CAs
Export-Certificate -cert $RootCACert -FilePath c:\temp\root-authority.crt
#add certificate to trusted root certificate authorities
$TrustedRootCAStore= new-object System.Security.Cryptography.X509Certificates.X509Store(“Root”,”LocalMachine”)
$TrustedRootCAStore.open(“MaxAllowed”)
$TrustedRootCAStore.add($RootCACert)
#WebServer Cert
# 1.3.6.1.5.5.7.3.1
New-SelfSignedCertificate -certstorelocation cert:\localmachine\my -FriendlyName “Certificate for Web Server” -TextExtension @(“2.5.29.37={text}1.3.6.1.5.5.7.3.1”) -dnsname $HostNameForCertificate,$AddionalHostNames -Signer $RootCACert
#IdentityServer token signing certificate
#1.3.6.1.5.5.7.3.3
New-SelfSignedCertificate -certstorelocation cert:\localmachine\my -FriendlyName “Certificate for IdentityServer Token Signing” -TextExtension @(“2.5.29.37={text}1.3.6.1.5.5.7.3.3”) -KeyUsage DigitalSignature -KeyAlgorithm RSA -KeyLength 2048 -dnsname $HostNameForCertificate,$AddionalHostNames -Signer $RootCACert