# CustomServerControls
Asp.net custom server control with child items example

# 1. Introduction

Custom ASP.Net server control.
The control renders an html <select></select> and uses jQuery to handle client side interaction.
The purpose of this project is a server control that does not use the standard ASP.Net features, like auto postback.

# 2. why
I am a freelancer that works on many projects. Mostly I work on fullstack (angular, .net mvc) + cms implementations. 
And sometimes I get to deal with legacy projects, like windows forms and in this case ASP.Net webforms.
The regular ASP.Net controls render inline javascript code. My client added new security rules (CSP headers) that enforces
inline js not to work anymore.

# 3. The control

3.1. Requirements
The control renders html that uses bootstrap, jquery

3.2. 


#credits

https://weblog.west-wind.com/posts/2004/Jan/14/Collection-properties-in-ASPNet-Server-Controls-Building-a-TabStrip-Control