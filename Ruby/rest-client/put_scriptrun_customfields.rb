require 'rest_client'
require 'json'

site = RestClient::Resource.new('http://username:password@localhost/EnterpriseTester/api/')

runId = '2cd6f2e7-df0d-4aa8-9e48-a14d00851623'

response = site['scriptrun/'+runId+'?$expand=FieldValues'].put ({ 'FieldValues' => { 'AdditionalNotes' => 'Here are some additional notes' } }).to_json, :content_type => :json, :accept => :json

print response.to_str