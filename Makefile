all:
	cd Library && ./build.sh
	cp Library/build/Release-iphone/lib/libGPUImage.a Binding/libGPUImage.a	
	$(MAKE) -C Binding
	
clean:
	rm -rf Library/build
	$(MAKE) -C Binding clean