#!/usr/bin/env python

# Generate 15,000 users in Enterprise Tester with admin permissions...
# This example requires Request library (http://docs.python-requests.org/en/latest/index.html)

import json
import requests
from requests.auth import HTTPBasicAuth

server = 'http://localhost/EnterpriseTester'
#proxyDict = { 'http': '127.0.0.1:8888'} # so we can capture requests in fiddler
auth = HTTPBasicAuth('Administrator', 'password')
headers = { 'content-type': 'application/json' }
all_perms = [{'Key': '/Administration'}, {'Key': '/Resources'},{'Key': '/Reports'}, {'Key':'/Project'},{'Key':'/TestManagement'}]

def get_rel(rel, json):
	for link in json['Links']:
		if link['Rel'] == rel: return link['Href']
	return None

def create_user(username):
	model =  { 'UserName': username, 'Email': 'noreply@unknown.org', 'Password': 'password'}
	users_collection_url = server + '/api/users'
	create_user_resp = requests.post(users_collection_url, auth=auth, data = json.dumps(model), proxies=proxyDict, headers=headers)
	perms_url = get_rel('GlobalPermissions', create_user_resp.json)
	requests.put(perms_url, auth=auth, data=json.dumps(all_perms), proxies=proxyDict, headers=headers)

for i in range(0,15000):
	suffix = str(i).rjust(5,'0')
	username = "user_" + suffix
	create_user(username)